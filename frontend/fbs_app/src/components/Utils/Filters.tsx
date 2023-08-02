import React from "react";
import classes from "./styles/Filters.module.css";
import CountrySelect from "./CountrySelect";
import { useState, useEffect } from "react";

const Filters = (props) => {
  const [selectedCountry, setSelectedCountry] = useState(
    props.selected.value === "0" ? null : props.selected
  );
  const [teamName, setTeamName] = useState(props.selectedName);
  const changeCountryHandler = (value: any) => {
    setSelectedCountry(value);
  };

  useEffect(() => {
    if (!selectedCountry) {
      props.onChange({
        value: "0",
        label: "",
        image: "",
      });
    } else {
      props.onChange(selectedCountry);
    }
  }, [selectedCountry]);

  const changeTeamNameHandler = () => {
    console.log("as");
    setTeamName(event?.target.value);
  };

  useEffect(() => {
    props.onChangeTeamName(teamName);
  }, [teamName]);

  return (
    <div className={classes.filters}>
      <CountrySelect
        countries={props.countries}
        onChange={changeCountryHandler}
        selected={selectedCountry}
      ></CountrySelect>
      <div className={classes.nameInputContainer}>
        <label>Name: </label>
        <input
          placeholder="Team name..."
          className={classes.nameInput}
          value={teamName}
          onChange={changeTeamNameHandler}
        ></input>
      </div>
    </div>
  );
};

export default Filters;
