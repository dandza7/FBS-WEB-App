import React from "react";
import classes from "./styles/Players.module.css";
import { useState, useContext, useEffect } from "react";
import AuthContext from "../store/auth-context";
import FilterAltIcon from "@mui/icons-material/FilterAlt";
import Filters from "../components/Utils/Filters";
import PlayerCard from "../components/Players/PlayerCard";
import Pagination from "../components/Utils/Pagination";
import { useNavigate } from "react-router";
import ReactLoading from "react-loading";

const Players = () => {
  const pageSize = 10;
  const [players, setPlayers] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const [selectedCountry, setSelectedCountry] = useState(0);
  const [countries, setCountries] = useState<any[]>([]);
  const [toggleFilters, setToggleFilters] = useState(false);
  const [playerName, setPlayerName] = useState("");
  const [playerPos, setPlayerPos] = useState({ value: "ALL", label: "" });
  const [totalCount, setTotalCount] = useState(null);
  const [selectedPage, setSelectedPage] = useState(1);
  const navigate = useNavigate();
  const [isLoading, setIsLoading] = useState(false);

  const changePage = (page: number) => {
    setSelectedPage(page);
    window.scrollTo({ top: 0, left: 0 });
  };

  const setPage1 = () => {
    setSelectedPage(1);
  };

  const changeCountryHandler = (value: any) => {
    setSelectedCountry(value);
  };

  const changeNameHandler = (value: any) => {
    setPlayerName(value);
  };

  const changePositionHandler = (value: any) => {
    setPlayerPos(value);
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
    setIsLoading(true);
    fetch("http://localhost:5271/api/players", {
      method: "POST",
      body: JSON.stringify({
        isOrderAscending: true,
        countryId: selectedCountry.value,
        name: playerName,
        position: playerPos.value,
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
        setPlayers(data.entities);
        setIsLoading(false);
      })
      .catch((error) => {
        alert(error);
      });
  }, [selectedCountry, playerName, playerPos, selectedPage]);

  return (
    <div>
      <div className={classes.whiteContainer}>
        <div className={classes.titleFiltersContainer}>
          <h2>Players</h2>
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
              filters={["playerName", "playerPos"]}
              countries={countries}
              onChange={changeCountryHandler}
              selected={selectedCountry}
              onChangePlayerName={changeNameHandler}
              selectedName={playerName}
              selectedPos={playerPos}
              onChangePlayerPos={changePositionHandler}
              setPage1={setPage1}
            ></Filters>
          )}
        </div>
        {isLoading ? (
          <div className={classes.loadingContainer}>
            <ReactLoading
              type={"spin"}
              color={"#1f2466"}
              height={30}
              width={30}
            />
          </div>
        ) : players.length > 0 ? (
          <>
            <div className={classes.players}>
              {players?.map((player) => (
                <PlayerCard player={player} key={player.id}></PlayerCard>
              ))}
            </div>
            {totalCount > pageSize && (
              <Pagination
                change={changePage}
                totalCount={totalCount}
                pageSize={pageSize}
                currentPage={selectedPage}
              ></Pagination>
            )}{" "}
          </>
        ) : (
          <div>There are no players that match your search criteria.</div>
        )}
      </div>
    </div>
  );
};

export default Players;
