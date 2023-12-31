import React from "react";
import { useNavigate, useParams } from "react-router";
import classes from "./styles/Match.module.css";
import { useState, useEffect } from "react";
import dayjs from "dayjs";
import SportsSoccerIcon from "@mui/icons-material/SportsSoccer";

const stats = [
  { value: "shots", label: "Shots" },
  { value: "shotsOnTarget", label: "Shots on target" },
  { value: "blockedShots", label: "Blocked shots" },
  { value: "freeKicks", label: "Free kicks" },
  { value: "cornerKicks", label: "Corner kicks" },
  { value: "offsides", label: "Offsides" },
  { value: "possession", label: "Possession" },
  { value: "saves", label: "Saves" },
  { value: "fouls", label: "Fouls" },
  { value: "redCards", label: "Red cards" },
  { value: "yellowCards", label: "Yellow cards" },
  { value: "tackles", label: "Tackles" },
  { value: "passes", label: "Passes" },
];

export const Match = () => {
  const { id } = useParams();
  const navigate = useNavigate();
  const [showStatistics, setShowStatistics] = useState(true);
  const [match, setMatch] = useState(null);
  const [homeTeamStats, setHomeTeamStats] = useState(null);
  const [awayTeamStats, setAwayTeamStats] = useState(null);
  const [homeTeamSquad, setHomeTeamSquad] = useState<any[]>([]);
  const [awayTeamSquad, setAwayTeamSquad] = useState<any[]>([]);
  const [teamSquad, setTeamSquad] = useState(null);
  useEffect(() => {
    fetch("http://localhost:5271/api/matches/" + id, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        setMatch(data);
        fetchStats();
        fetchSquads();
      })
      .catch((error) => {
        alert(error);
      });
  }, []);

  const fetchStats = () => {
    fetch("http://localhost:5271/api/matches/" + id + "/stats", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        setHomeTeamStats(data.homeTeamStats);
        setAwayTeamStats(data.awayTeamStats);
      })
      .catch((error) => {
        alert(error);
      });
  };

  const fetchSquads = () => {
    fetch("http://localhost:5271/api/matches/" + id + "/squads", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        setTeamSquad(data);
        const prviTimDomacin = [];
        const prviTimGost = [];
        const izmeneDomacin = [];
        const izmeneGost = [];
        data.homeTeam.map((player) => {
          if (player.isStarter) {
            prviTimDomacin.push(player);
          } else {
            izmeneDomacin.push(player);
          }
        });
        data.awayTeam.map((player) => {
          if (player.isStarter) {
            prviTimGost.push(player);
          } else {
            izmeneGost.push(player);
          }
        });
        setHomeTeamSquad({ starters: prviTimDomacin, changes: izmeneDomacin });
        setAwayTeamSquad({ starters: prviTimGost, changes: izmeneGost });
      })
      .catch((error) => {
        alert(error);
      });
  };

  return (
    <div className={classes.player}>
      <div className={classes.whiteContainerTitle}>
        <div className={classes.matchContainer}>
          <div className={classes.teamContainer}>
            <div className={classes.teamImageContainer}>
              <img
                className={classes.teamImage}
                src={`data:image/png;base64,${match?.homeTeam?.logo}`}
              ></img>
            </div>
            <span>{match?.homeTeam?.name}</span>
          </div>

          <div className={classes.resultContainer}>
            <div className={classes.result}>
              <span className={classes.resultGoals}>
                {match?.homeTeamGoals}
              </span>
              <span className={classes.resultGoals}>:</span>
              <span className={classes.resultGoals}>
                {match?.awayTeamGoals}
              </span>
            </div>
            <div className={classes.gameWeek}>Gameweek {match?.gameweek}</div>
            <div className={classes.date}>
              <span>{dayjs(match?.date).format("DD.MM.YYYY.")}</span>
            </div>
          </div>
          <div className={classes.teamContainer}>
            <div className={classes.teamImageContainer}>
              <img
                className={classes.teamImage}
                src={`data:image/png;base64,${match?.awayTeam?.logo}`}
              ></img>
            </div>
            <span>{match?.awayTeam?.name}</span>
          </div>
        </div>
      </div>

      <div className={classes.playerMenu}>
        <div
          className={
            showStatistics
              ? classes.playerMenuItemSelected
              : classes.playerMenuItem
          }
          onClick={() => setShowStatistics(true)}
        >
          Statistics
        </div>
        <div
          className={
            !showStatistics
              ? classes.playerMenuItemSelected
              : classes.playerMenuItem
          }
          onClick={() => setShowStatistics(false)}
        >
          Squads
        </div>
      </div>
      <div className={classes.whiteContainer}>
        {showStatistics && (
          <>
            {
              <>
                <h3>Statistics</h3>
                <br></br>
                <div className={classes.statistics}>
                  {stats.map((stat) => (
                    <div className={classes.statistic}>
                      <div className={classes.statNumberHome}>
                        {homeTeamStats && (
                          <span
                            className={
                              homeTeamStats[stat.value] >
                              awayTeamStats[stat.value]
                                ? classes.winner
                                : classes.loser
                            }
                          >
                            {homeTeamStats && homeTeamStats[stat.value]}
                          </span>
                        )}
                      </div>
                      <div className={classes.statName}>{stat.label}</div>
                      <div className={classes.statNumberAway}>
                        {awayTeamStats && (
                          <span
                            className={
                              awayTeamStats[stat.value] >
                              homeTeamStats[stat.value]
                                ? classes.winner
                                : classes.loser
                            }
                          >
                            {awayTeamStats && awayTeamStats[stat.value]}
                          </span>
                        )}
                      </div>
                    </div>
                  ))}
                </div>
              </>
            }
          </>
        )}
        {!showStatistics && (
          <>
            <h3>Squads</h3>
            <br></br>
            <div className={classes.tableTitle}>
              <div>Starting lineups</div>
            </div>
            <div className={classes.squads}>
              <div className={classes.homeTeamSuad}>
                {homeTeamSquad.starters?.map((player) => (
                  <div className={classes.homeSquadPlayer}>
                    <img
                      className={classes.playerFlag}
                      src={`data:image/png;base64,${player.flag}`}
                    ></img>
                    <div
                      className={classes.playerName}
                      onClick={() => {
                        navigate("/player/" + player.id);
                      }}
                    >
                      {player?.name}
                    </div>
                    <div className={classes.playerMinutes}>
                      {player?.minutes}'
                    </div>
                    {player.goals > 0 && (
                      <div className={classes.playerGoals}>
                        <SportsSoccerIcon fontSize="small"></SportsSoccerIcon>
                        {player.goals > 1 && (
                          <div className={classes.goalNumber}>
                            {player.goals}
                          </div>
                        )}
                      </div>
                    )}
                    {player.ownGoals > 0 && (
                      <div className={classes.playerAutoGoals}>
                        <SportsSoccerIcon fontSize="small"></SportsSoccerIcon>
                      </div>
                    )}
                  </div>
                ))}
              </div>
              <div className={classes.awayTeamSuad}>
                {awayTeamSquad.starters?.map((player) => (
                  <div className={classes.awaySquadPlayer}>
                    {player.ownGoals > 0 && (
                      <div className={classes.playerAutoGoals}>
                        <SportsSoccerIcon fontSize="small"></SportsSoccerIcon>
                      </div>
                    )}
                    {player.goals > 0 && (
                      <div className={classes.playerGoals}>
                        <SportsSoccerIcon fontSize="small"></SportsSoccerIcon>
                        {player.goals > 1 && (
                          <div className={classes.goalNumber}>
                            {player.goals}
                          </div>
                        )}
                      </div>
                    )}
                    <div className={classes.playerMinutes}>
                      {player?.minutes}'
                    </div>
                    <div
                      className={classes.playerName}
                      onClick={() => {
                        navigate("/player/" + player.id);
                      }}
                    >
                      {player?.name}
                    </div>
                    <img
                      className={classes.playerFlag}
                      src={`data:image/png;base64,${player.flag}`}
                    ></img>
                  </div>
                ))}
              </div>
            </div>
            <div className={classes.tableTitle}>Substitutes</div>
            <div className={classes.squads}>
              <div className={classes.homeTeamSuad}>
                {homeTeamSquad.changes?.map((player) => (
                  <div className={classes.homeSquadPlayer}>
                    <img
                      className={classes.playerFlag}
                      src={`data:image/png;base64,${player.flag}`}
                    ></img>
                    <div
                      className={classes.playerName}
                      onClick={() => {
                        navigate("/team/" + player.id);
                      }}
                    >
                      {player?.name}
                    </div>
                    {player.minutes > 0 && (
                      <div className={classes.playerMinutes}>
                        {player?.minutes}'
                      </div>
                    )}
                    {player.goals > 0 && (
                      <div className={classes.playerGoals}>
                        <SportsSoccerIcon fontSize="small"></SportsSoccerIcon>
                        {player.goals > 1 && (
                          <div className={classes.goalNumber}>
                            {player.goals}
                          </div>
                        )}
                      </div>
                    )}
                  </div>
                ))}
              </div>
              <div className={classes.awayTeamSuad}>
                {awayTeamSquad.changes?.map((player) => (
                  <div className={classes.awaySquadPlayer}>
                    {player.goals > 0 && (
                      <div className={classes.playerGoals}>
                        <SportsSoccerIcon fontSize="small"></SportsSoccerIcon>
                        {player.goals > 1 && (
                          <div className={classes.goalNumber}>
                            {player.goals}
                          </div>
                        )}
                      </div>
                    )}
                    {player.minutes > 0 && (
                      <div className={classes.playerMinutes}>
                        {player?.minutes}'
                      </div>
                    )}
                    <div
                      className={classes.playerName}
                      onClick={() => {
                        navigate("/player/" + player.id);
                      }}
                    >
                      {player?.name}
                    </div>
                    <img
                      className={classes.playerFlag}
                      src={`data:image/png;base64,${player.flag}`}
                    ></img>
                  </div>
                ))}
              </div>
            </div>
          </>
        )}
      </div>
    </div>
  );
};
