import React from "react";
import classes from "./styles/Players.module.css";

const Players = () => {
  return (
    <div>
      <div className={classes.whiteContainer}>
        <h2>Players</h2>
        <br></br>
        <div className={classes.players}>
          <table className={classes.playersTable}>
            <thead>
              <tr>
                <th>Full Name</th>
                <th>Country</th>
                <th>Team</th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <td>Paul Pogba</td>
                <td>France</td>
                <td>Juventus FC</td>
              </tr>
              <tr>
                <td>Paul Pogba</td>
                <td>France</td>
                <td>Juventus FC</td>
              </tr>
              <tr>
                <td>Paul Pogba</td>
                <td>France</td>
                <td>Juventus FC</td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </div>
  );
};

export default Players;
