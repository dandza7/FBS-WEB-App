import React from "react";
import classes from "./styles/Teams.module.css";
import { useState, useContext, useEffect } from "react";
import AuthContext from "../store/auth-context";
import Select from "react-select";
import CountrySelect from "../components/Utils/CountrySelect";
import FilterAltIcon from "@mui/icons-material/FilterAlt";
import CloseIcon from "@mui/icons-material/Close";
import Filters from "../components/Utils/Filters";
import TeamCard from "../components/Teams/TeamCard";
import Pagination from "../components/Utils/Pagination";
import { useNavigate } from "react-router";

const Teams = () => {
  const [teams, setTeams] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const [selectedCountry, setSelectedCountry] = useState(0);
  const [countries, setCountries] = useState<any[]>([]);
  const [toggleFilters, setToggleFilters] = useState(false);
  const [teamName, setTeamName] = useState("");
  const pageSize = 10;
  const [totalCount, setTotalCount] = useState(null);
  const [selectedPage, setSelectedPage] = useState(1);
  const navigate = useNavigate();

  const setPage1 = () => {
    console.log("promenjeno");
    setSelectedPage(1);
  };

  const changePage = (page: number) => {
    setSelectedPage(page);
    window.scrollTo({ top: 0, left: 0 });
  };

  const changeCountryHandler = (value: any) => {
    setSelectedCountry(value);
  };

  const changeNameHandler = (value: any) => {
    setSelectedPage(1);
    setTeamName(value);
  };

  useEffect(() => {
    fetch("http://localhost:5271/api/countries", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        const allCountries: any = [];
        data.map((item: any) => {
          allCountries.push({
            value: item.id,
            label: item.name,
            image: `data:image/png;base64,${item.flag}`,
          });
        });
        setCountries(allCountries);
      })
      .catch((error) => {
        alert(error);
      });
  }, []);

  useEffect(() => {
    fetch("http://localhost:5271/api/teams", {
      method: "POST",
      body: JSON.stringify({
        isOrderAscending: true,
        countryId: selectedCountry.value,
        name: teamName,
        pageSize: pageSize,
        page: selectedPage,
      }),
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        setTotalCount(data.totalCount);
        setTeams(data.entities);
      })
      .catch((error) => {
        alert(error);
      });
  }, [selectedCountry, teamName, selectedPage]);

  const viewTeamHandler = (id: number) => {
    navigate("/team/" + id);
  };
  return (
    <div>
      {teams.length > 0 ? (
        <div className={classes.whiteContainer}>
          <div className={classes.titleFiltersContainer}>
            <h2>Teams</h2>
            <div
              className={classes.filterButton}
              onClick={() => {
                setToggleFilters((prevState) => {
                  return !prevState;
                });
              }}
            >
              <FilterAltIcon></FilterAltIcon>
            </div>
          </div>
          <div className={classes.rightContainer}>
            {toggleFilters && (
              <Filters
                filters={["teamName"]}
                countries={countries}
                onChange={changeCountryHandler}
                selected={selectedCountry}
                onChangeTeamName={changeNameHandler}
                selectedName={teamName}
                setPage1={setPage1}
              ></Filters>
            )}
          </div>
          <div className={classes.teams}>
            {teams?.map((team) => (
              <TeamCard
                team={team}
                key={team.id}
                onClick={viewTeamHandler}
              ></TeamCard>
            ))}
          </div>

          <Pagination
            change={changePage}
            totalCount={totalCount}
            pageSize={pageSize}
            currentPage={selectedPage}
          ></Pagination>
        </div>
      ) : (
        <div>asd</div>
      )}
    </div>
  );
};

export default Teams;
