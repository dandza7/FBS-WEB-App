import React from "react";
import classes from "./styles/CountrySelect.module.css";
import Select from "react-select";
import { useState, useContext, useEffect } from "react";

const CountrySelect = (props: any) => {
  const [selectedCountry, setSelectedCountry] = useState(
    props ? props.selected : null
  );

  useEffect(() => {
    console.log(props.selected);
  }, []);

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

  return (
    <div className={classes.countrySelectContainer}>
      <span>Country:</span>
      <Select
        defaultValue={selectedCountry}
        onChange={setSelectedCountry}
        options={props.countries}
        isClearable
        placeholder="Select country..."
        formatOptionLabel={(country: any) => (
          <div className={classes.optionContainer}>
            <img
              src={country.image}
              className={classes.optionImage}
              alt="country-image"
            />
            <span>{country.label}</span>
          </div>
        )}
      />
    </div>
  );
};

export default CountrySelect;
