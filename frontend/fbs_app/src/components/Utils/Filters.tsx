import React from "react";
import classes from "./styles/Filters.module.css";
import CountrySelect from "./CountrySelect";
import { useState, useEffect } from "react";
import Select from "react-select";

const positions = [
  { value: "Goalkeeper", label: "Goalkeeper" },
  { value: "Defender", label: "Defender" },
  { value: "Midfielder", label: "Midfielder" },
  { value: "Attacker", label: "Attacker" },
];
const Filters = (props) => {
  const [selectedCountry, setSelectedCountry] = useState(
    props.selected?.value === "0" ? null : props.selected
  );
  const [teamName, setTeamName] = useState(props.selectedName);
  const [playerName, setPlayerName] = useState(props.selectedName);
  const [playerPos, setPlayerPos] = useState(
    props.selectedPos?.value === "ALL" ? null : props.selectedPos
  );
  const [firstRenderCountry, setFirstRenderCountry] = useState(true);
  const [firstRenderPos, setFirstRenderPos] = useState(true);

  const handleChange = (selected) => {
    props.setPage1();
    if (!selected) {
      props.onChangePlayerPos({
        value: "ALL",
        label: "",
      });
    } else {
      props.onChangePlayerPos(selected);
    }
  };

  const changeCountryHandler = (value: any) => {
    props.setPage1();
    if (!value) {
      props.onChange({
        value: "0",
        label: "",
        image: "",
      });
    } else {
      props.onChange(value);
    }
  };

  const changeTeamNameHandler = () => {
    props.setPage1();
    setTeamName(event?.target.value);
  };

  const changePlayerNameHandler = () => {
    props.setPage1();
    setPlayerName(event?.target.value);
  };

  useEffect(() => {
    if (props.filters.includes("teamName")) {
      props.onChangeTeamName(teamName);
    }
  }, [teamName]);

  useEffect(() => {
    if (props.filters.includes("playerName")) {
      props.onChangePlayerName(playerName);
    }
  }, [playerName]);

  return (
    <div className={classes.filters}>
      {props?.filters.includes("teamName") && (
        <div className={classes.nameInputContainer}>
          <label>Name: </label>
          <input
            placeholder="Team name..."
            className={classes.nameInput}
            value={teamName}
            onChange={changeTeamNameHandler}
          ></input>
        </div>
      )}
      {props?.filters.includes("playerName") && (
        <div className={classes.nameInputContainer}>
          <label>Name: </label>
          <input
            placeholder="Player name..."
            className={classes.nameInput}
            value={playerName}
            onChange={changePlayerNameHandler}
          ></input>
        </div>
      )}
      {props?.filters.includes("playerPos") && (
        <div className={classes.nameInputContainer}>
          <label>Position: </label>
          <Select
            className={classes.select}
            defaultValue={playerPos}
            onChange={handleChange}
            options={positions}
            isClearable
            placeholder="Select position..."
          />
        </div>
      )}
      <CountrySelect
        countries={props.countries}
        onChange={changeCountryHandler}
        selected={selectedCountry}
      ></CountrySelect>
    </div>
  );
};

export default Filters;
