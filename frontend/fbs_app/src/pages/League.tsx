import React from "react";
import classes from "./styles/League.module.css";
import { useState, useEffect } from "react";
import Select from "react-select";
import ReactLoading from "react-loading";

const allSeasons = [{ value: 1, label: "1" }];

const League = () => {
  const [isScoreboard, setIsScoreboard] = useState(false);
  const [selectedSeason, setSelectedSeason] = useState(null);
  const [scoreBoard, setScoreBoard] = useState<any[]>([]);
  const [teamCount, setTeamCount] = useState(null);
  const [isLoading, setIsLoading] = useState(false);
  const handleChangeSeason = (selected) => {
    setSelectedSeason(selected);
  };

  useEffect(() => {
    console.log(selectedSeason?.value);
    setIsLoading(true);
    fetch(
      "http://localhost:5271/api/seasons/" + selectedSeason?.value + "/table",
      {
        method: "GET",
        headers: {
          "Content-Type": "application/json",
        },
      }
    )
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        setScoreBoard(data);
        setTeamCount(data.length);
        setIsLoading(false);
      })
      .catch((error) => {
        alert(error);
      });
  }, [selectedSeason]);

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
      <div className={classes.seasonContainer}>
        <div className={classes.seasonSelectContainer}>
          <span>Season:</span>
          <Select
            defaultValue={selectedSeason}
            onChange={handleChangeSeason}
            options={allSeasons}
            placeholder="Select season"
          />
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
          {isLoading ? (
            <div className={classes.loadingContainer}>
              <ReactLoading
                type={"spin"}
                color={"#1f2466"}
                height={30}
                width={30}
              />
            </div>
          ) : scoreBoard.length > 0 ? (
            <>
              <h3>Scoreboard</h3>
              <br></br>

              <div className={classes.scoreboard}>
                <table className={classes.leaguesTable}>
                  <thead>
                    <tr>
                      <th>#</th>
                      <th>Team</th>
                      <th>PG</th>
                      <th>W</th>
                      <th>D</th>
                      <th>L</th>
                      <th>GD</th>
                      <th>P</th>
                    </tr>
                  </thead>
                  <tbody>
                    {scoreBoard?.map((team, index) => (
                      <tr>
                        <td>
                          <span
                            className={
                              index === 0 ||
                              index === 1 ||
                              index === 2 ||
                              index === 3
                                ? classes.first
                                : index === 4
                                ? classes.second
                                : index === 17 || index === 18 || index === 19
                                ? classes.last
                                : classes.other
                            }
                          >
                            {`${index + 1}.`}{" "}
                          </span>
                        </td>
                        <td>
                          <div className={classes.imgNameColumn}>
                            {team?.logo && (
                              <img
                                className={classes.teamLogo}
                                src={`data:image/png;base64,${team?.logo}`}
                              ></img>
                            )}
                            <span>{team?.name}</span>
                          </div>
                        </td>

                        <td>{team.wins + team.draws + team.losses}</td>
                        <td>{team.wins}</td>
                        <td>{team.draws}</td>
                        <td>{team.losses}</td>
                        <td>
                          {team.goalsScored}:{team.goalsConceded}
                        </td>
                        <td>{team.wins * 3 + team.draws}</td>
                      </tr>
                    ))}
                  </tbody>
                </table>
              </div>
            </>
          ) : (
            <div>There is no data for this season.</div>
          )}
        </div>
      )}
    </div>
  );
};

export default League;
