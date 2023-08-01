import React from "react";
import classes from "./styles/Player.module.css";
import { useState } from "react";

const Player = () => {
  const [showMatches, setshowMaches] = useState(true);

  return (
    <div className={classes.player}>
      <div className={classes.whiteContainerTitle}>
        <div className={classes.playerInfo}>
          <div>
            <img
              className={classes.playerImage}
              src="https://img.a.transfermarkt.technology/portrait/big/88755-1684245748.jpg?lm=1"
            ></img>
          </div>
          <div className={classes.basicInfo}>
            <h2>Kevin De Bruyne</h2>
            <p>Age: 32</p>
            <p>Nation: Belgium</p>
            <p>Team: Manchester City</p>
            <p>Position: Midfielder</p>
          </div>
        </div>
      </div>
      <div className={classes.playerMenu}>
        <div
          className={classes.playerMenuItem}
          onClick={() => setshowMaches(true)}
        >
          Matches
        </div>
        <div
          className={classes.playerMenuItem}
          onClick={() => setshowMaches(false)}
        >
          Teams
        </div>
      </div>
      {showMatches && (
        <div className={classes.whiteContainer}>
          <h3>Matches</h3>
          <br></br>
          <div className={classes.results}>
            <div className={classes.result}>
              <div className={classes.teamsDateContainer}>
                <div>
                  <p>25.08.2023.</p>
                </div>
                <div>
                  <p>Tim1</p>
                  <p className={classes.winner}>Tim1</p>
                </div>
              </div>

              <div className={classes.score}>
                <p>2</p>
                <p>1</p>
              </div>
            </div>
            <div className={classes.result}>
              <div className={classes.teamsDateContainer}>
                <div>
                  <p>25.08.2023.</p>
                </div>
                <div>
                  <p className={classes.winner}>Tim1</p>
                  <p>Tim1</p>
                </div>
              </div>

              <div className={classes.score}>
                <p>2</p>
                <p>1</p>
              </div>
            </div>
            <div className={classes.result}>
              <div className={classes.teamsDateContainer}>
                <div>
                  <p>25.08.2023.</p>
                </div>
                <div>
                  <p className={classes.winner}>Tim1</p>
                  <p>Tim1</p>
                </div>
              </div>

              <div className={classes.score}>
                <p>2</p>
                <p>1</p>
              </div>
            </div>
          </div>
        </div>
      )}
      {!showMatches && (
        <div className={classes.whiteContainer}>
          <h3>Teams</h3>
          <br></br>
          <div className={classes.scoreboard}>
            <table className={classes.scoreboardTable}>
              <thead>
                <tr>
                  <th>Team</th>
                  <th>Season</th>
                  <th>MP</th>
                  <th>G</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>Velez</td>
                  <td>2022/2023</td>
                  <td>0</td>
                  <td>0</td>
                </tr>
                <tr>
                  <td>Velez</td>
                  <td>2022/2023</td>
                  <td>0</td>
                  <td>0</td>
                </tr>
                <tr>
                  <td>Velez</td>
                  <td>2022/2023</td>
                  <td>0</td>
                  <td>0</td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
      )}
    </div>
  );
};

export default Player;
