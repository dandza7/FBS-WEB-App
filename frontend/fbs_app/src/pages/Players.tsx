import React from "react";
import classes from "./styles/Players.module.css";
import { useState, useContext, useEffect } from "react";
import AuthContext from "../store/auth-context";
import FilterAltIcon from "@mui/icons-material/FilterAlt";
import Filters from "../components/Utils/Filters";
import PlayerCard from "../components/Players/PlayerCard";

const Players = () => {
  const [players, setPlayers] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const [selectedCountry, setSelectedCountry] = useState(0);
  const [countries, setCountries] = useState<any[]>([]);
  const [toggleFilters, setToggleFilters] = useState(false);
  const [playerName, setPlayerName] = useState("");
  const [playerPos, setPlayerPos] = useState({ value: "ALL", label: "" });

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

  const handleInputChange = (event) => {
    console.log(event?.target.value);
    setPlayerName(event?.target.value);
  };

  useEffect(() => {
    fetch("http://localhost:5271/api/players", {
      method: "POST",
      body: JSON.stringify({
        isOrderAscending: true,
        countryId: selectedCountry.value,
        name: playerName,
        position: playerPos.value,
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
        setPlayers(data.entities);
      })
      .catch((error) => {
        alert(error);
      });
  }, [selectedCountry, playerName, playerPos]);

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
            ></Filters>
          )}
        </div>
        <div className={classes.players}>
          {players?.map((player) => (
            <PlayerCard player={player} key={player.id}></PlayerCard>
          ))}
        </div>
      </div>
    </div>
  );
};

export default Players;
