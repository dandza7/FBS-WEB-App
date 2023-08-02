import React from "react";
import classes from "./styles/Teams.module.css";
import { useState, useContext, useEffect } from "react";
import AuthContext from "../store/auth-context";
import Select from "react-select";
import CountrySelect from "../components/Utils/CountrySelect";
import FilterAltIcon from "@mui/icons-material/FilterAlt";
import CloseIcon from "@mui/icons-material/Close";
import Filters from "../components/Utils/Filters";

const Teams = () => {
  const [teams, setTeams] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const [selectedCountry, setSelectedCountry] = useState(0);
  const [countries, setCountries] = useState<any[]>([]);
  const [toggleFilters, setToggleFilters] = useState(false);
  const [teamName, setTeamName] = useState("");

  const changeCountryHandler = (value: any) => {
    setSelectedCountry(value);
  };

  const changeNameHandler = (value: any) => {
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

  const handleInputChange = (event) => {
    console.log(event?.target.value);
    setTeamName(event?.target.value);
  };

  useEffect(() => {
    fetch("http://localhost:5271/api/teams", {
      method: "POST",
      body: JSON.stringify({
        isOrderAscending: true,
        countryId: selectedCountry.value,
        name: teamName,
        pageSize: 10,
        page: 1,
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
        console.log(data.entities);
        setTeams(data.entities);
      })
      .catch((error) => {
        alert(error);
      });
  }, [selectedCountry, teamName]);

  return (
    <div>
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
              countries={countries}
              onChange={changeCountryHandler}
              selected={selectedCountry}
              onChangeTeamName={changeNameHandler}
              selectedName={teamName}
            ></Filters>
          )}
        </div>
        <div className={classes.teams}>
          {teams.map((team) => (
            <div key={team.id} className={classes.team}>
              <img
                src={`data:image/png;base64,${team.logo}`}
                className={classes.logo}
              ></img>
              <p>{team.name}</p>
              <img
                src={`data:image/png;base64,${team.flag}`}
                className={classes.flag}
              ></img>
            </div>
          ))}
        </div>
      </div>
    </div>
  );
};

export default Teams;
