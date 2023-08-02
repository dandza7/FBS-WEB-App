import React from "react";
import classes from "./styles/CountrySelect.module.css";
import Select from "react-select";

const CountrySelect = (props: any) => {
  return (
    <div className={classes.countrySelectContainer}>
      <span>Country:</span>
      <Select
        onChange={props.onChange}
        options={props.countries}
        placeholder="Select country"
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
