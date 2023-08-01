import React from "react";
import classes from "./styles/Teams.module.css";

const Teams = () => {
  return (
    <div>
      <div className={classes.whiteContainer}>
        <h3>Teams</h3>
        <br></br>
        <div className={classes.teams}>
          <table className={classes.teamsTable}>
            <thead>
              <tr>
                <th>Team</th>
                <th>City</th>
                <th>Country</th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <td>Juventus FC</td>
                <td>Torino</td>
                <td>Italy</td>
              </tr>
              <tr>
                <td>Milano</td>
                <td>AC Milan</td>
                <td>Italy</td>
              </tr>
              <tr>
                <td>FC Inter Milan</td>
                <td>Milano</td>
                <td>Italy</td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </div>
  );
};

export default Teams;
