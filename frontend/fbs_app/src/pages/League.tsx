import React from "react";
import classes from "./styles/League.module.css";
import { useState } from "react";

const League = () => {
  const [isScoreboard, setIsScoreboard] = useState(false);

  return (
    <div className={classes.league}>
      <div className={classes.whiteContainerTitle}>
        <h2>League title</h2>
        <p>2022/2023</p>
      </div>
      <div className={classes.leagueMenu}>
        <div
          className={classes.leagueMenuItem}
          onClick={() => setIsScoreboard(false)}
        >
          Matches
        </div>
        <div
          className={classes.leagueMenuItem}
          onClick={() => setIsScoreboard(true)}
        >
          Scoreboard
        </div>
      </div>
      {!isScoreboard && (
        <div className={classes.whiteContainer}>
          <h3>Results</h3>
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
      {isScoreboard && (
        <div className={classes.whiteContainer}>
          <h3>Scoreboard</h3>
          <br></br>
          <div className={classes.scoreboard}>
            <table className={classes.scoreboardTable}>
              <thead>
                <tr>
                  <th>#</th>
                  <th>Team</th>
                  <th>W</th>
                  <th>D</th>
                  <th>L</th>
                  <th>GD</th>
                  <th>P</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>1.</td>
                  <td>Velez</td>
                  <td>1</td>
                  <td>0</td>
                  <td>0</td>
                  <td>2:0</td>
                  <td>3</td>
                </tr>
                <tr>
                  <td>2.</td>
                  <td>Velez</td>
                  <td>1</td>
                  <td>0</td>
                  <td>0</td>
                  <td>2:0</td>
                  <td>3</td>
                </tr>
                <tr>
                  <td>3.</td>
                  <td>Velez</td>
                  <td>1</td>
                  <td>0</td>
                  <td>0</td>
                  <td>2:0</td>
                  <td>3</td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
      )}
    </div>
  );
};

export default League;
