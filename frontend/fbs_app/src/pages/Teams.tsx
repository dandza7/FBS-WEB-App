import React from "react";
import classes from "./styles/Teams.module.css";
import { useState, useContext, useEffect } from "react";
import AuthContext from "../store/auth-context";
import Select from "react-select";
import CountrySelect from "../components/Utils/CountrySelect";

const countries = [
  {
    value: "Australia",
    label: "Australia",
    image: "https://cdn.britannica.com/78/6078-004-77AF7322/Flag-Australia.jpg",
  },
  {
    value: "Serbia",
    label: "Serbia",
    image:
      "https://upload.wikimedia.org/wikipedia/commons/f/ff/Flag_of_Serbia.svg",
  },
];

const Teams = () => {
  const [teams, setTeams] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const [selectedCountry, setSelectedCountry] = useState(null);

  const changeCountryHandler = (event: any) => {
    setSelectedCountry(event.value);
  };

  useEffect(() => {
    fetch("http://localhost:5271/api/teams", {
      method: "POST",
      body: JSON.stringify({
        isOrderAscending: true,
        countryId: 0,
        name: "",
        pageSize: 5,
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
  }, []);

  return (
    <div>
      <div className={classes.whiteContainer}>
        <h2>Teams</h2>
        <br></br>
        <div className={classes.teams}>
          <CountrySelect
            countries={countries}
            onChange={changeCountryHandler}
          ></CountrySelect>

          {teams.map((team) => (
            <div key={team.id} className={classes.team}>
              <img
                src={`data:image/png;base64,${team.flag}`}
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
