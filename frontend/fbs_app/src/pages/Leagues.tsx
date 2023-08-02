import React from "react";
import classes from "./styles/Leagues.module.css";

const Leagues = () => {
  return (
    <div>
      <div className={classes.whiteContainer}>
        <h2>Leagues</h2>
        <br></br>
        <div className={classes.leagues}>
          <table className={classes.leaguesTable}>
            <thead>
              <tr>
                <th>Name</th>
                <th>Country</th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <td>Serie A</td>
                <td>Italy</td>
              </tr>
              <tr>
                <td>Premier League</td>
                <td>England</td>
              </tr>
              <tr>
                <td>Bundesliga</td>
                <td>Germany</td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </div>
  );
};

export default Leagues;
