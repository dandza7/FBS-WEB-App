import React from "react";
import classes from "./styles/Team.module.css";
import { useState, useEffect } from "react";
import Players from "../components/Players/Players";
import Select from "react-select";
import { useParams } from "react-router";
import Teams from "./Teams";
import dayjs from "dayjs";
import { useNavigate } from "react-router";

const seasons = [
  { value: "2020/2021", label: "2020/2021" },
  { value: "2021/2022", label: "2021/2022" },
  { value: "2022/2023", label: "2022/2023" },
];

const Team = () => {
  const [tab, setTab] = useState("Stats");
  const [selectedSeason, setSelectedSeason] = useState(null);
  const [team, setTeam] = useState(null);
  const { id } = useParams();
  const [matches, setMatches] = useState<any[]>([]);
  const navigate = useNavigate();

  const viewAllMatchesHandler = () => {
    navigate("/team/" + id + "/matches");
  };

  const getTeamMatches = () => {
    fetch(`http://localhost:5271/api/teams/${id}/matches/1/5`, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        console.log(data);
        setMatches(data.entities);
      })
      .catch((error) => {
        alert(error);
      });
  };

  useEffect(() => {
    fetch("http://localhost:5271/api/teams/" + id + "/detailed", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        console.log(data);
        setTeam(data);
      })
      .catch((error) => {
        alert(error);
      });
  }, []);

  return (
    <div className={classes.team}>
      <div className={classes.whiteContainerTitle}>
        <div className={classes.teamInfo}>
          <div>
            <img
              className={classes.teamImage}
              src={`data:image/png;base64,${team?.logo}`}
            ></img>
          </div>
          <div className={classes.basicInfo}>
            <h2>{team?.name}</h2>
            <p>Stadium : {team?.stadiumName}</p>
          </div>
        </div>
      </div>
      <div className={classes.teamMenu}>
        <div className={classes.teamMenuItem} onClick={() => setTab("Stats")}>
          Stats
        </div>
        <div className={classes.teamMenuItem} onClick={() => setTab("Squad")}>
          Squad
        </div>
        <div
          className={classes.teamMenuItem}
          onClick={() => {
            setTab("Matches");
            getTeamMatches();
          }}
        >
          Matches
        </div>
      </div>
      <div className={classes.seasonContainer}>
        <div className={classes.seasonSelectContainer}>
          <span>Season:</span>
          <Select
            defaultValue={selectedSeason}
            onChange={setSelectedSeason}
            options={seasons}
            isClearable
            placeholder="Select season"
          />
        </div>
      </div>
      {tab === "Stats" && (
        <div className={classes.whiteContainerInfo}>
          <h3>Statistics</h3>
          <br></br>
          <div className={classes.statistics}></div>
        </div>
      )}
      {tab === "Squad" && <Players></Players>}
      {tab === "Matches" && (
        <div className={classes.whiteContainerInfo}>
          <h3>Matches</h3>
          <br></br>
          <div className={classes.results}>
            {matches.map((match) => (
              <div className={classes.result}>
                <div className={classes.teamsDateContainer}>
                  <div>
                    <p>{dayjs(match.date).format("DD.MM")}</p>
                  </div>
                  <div className={classes.resultTeamsContainer}>
                    <div className={classes.matchTeam}>
                      <img
                        className={classes.matchTeamLogo}
                        src={`data:image/png;base64,${match.homeTeam.logo}`}
                      ></img>
                      <span
                        className={
                          match.homeTeamGoals > match.awayTeamGoals &&
                          classes.winner
                        }
                      >
                        {match.homeTeam.name}
                      </span>
                    </div>
                    <div className={classes.matchTeam}>
                      <img
                        className={classes.matchTeamLogo}
                        src={`data:image/png;base64,${match.awayTeam.logo}`}
                      ></img>
                      <span
                        className={
                          match.homeTeamGoals < match.awayTeamGoals &&
                          classes.winner
                        }
                      >
                        {match.awayTeam.name}
                      </span>
                    </div>
                  </div>
                </div>

                <div className={classes.score}>
                  <p>{match.homeTeamGoals}</p>
                  <p>{match.awayTeamGoals}</p>
                </div>
              </div>
            ))}
          </div>
          <div className={classes.containerCenter}>
            <button
              className={classes.viewAllMatchesButton}
              onClick={viewAllMatchesHandler}
            >
              View all
            </button>
          </div>
        </div>
      )}
    </div>
  );
};
export default Team;
