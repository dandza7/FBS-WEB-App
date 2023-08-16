import React from "react";
import classes from "./Results.module.css";
import dayjs from "dayjs";
import { useNavigate } from "react-router";
import SportsSoccerIcon from "@mui/icons-material/SportsSoccer";

const PlayerResultCard = (props: any) => {
  const navigate = useNavigate();

  return (
    <div
      className={classes.result}
      key={props.match.id}
      onClick={() => {
        navigate("/match/" + props.match.id);
      }}
    >
      <div className={classes.teamsDateContainer}>
        <div>
          <p>{dayjs(props.match.date).format("DD.MM")}</p>
        </div>

        <div className={classes.resultTeamsContainer}>
          <div className={classes.matchTeam}>
            <img
              className={classes.matchTeamLogo}
              src={`data:image/png;base64,${props.match.homeTeam?.logo}`}
            ></img>
            <span
              className={
                props.match.homeTeamGoals > props.match.awayTeamGoals
                  ? classes.winner
                  : classes.none
              }
            >
              {props.match.homeTeam.name}
            </span>
          </div>
          <div className={classes.matchTeam}>
            <img
              className={classes.matchTeamLogo}
              src={`data:image/png;base64,${props.match.awayTeam?.logo}`}
            ></img>
            <span
              className={
                props.match.homeTeamGoals < props.match.awayTeamGoals
                  ? classes.winner
                  : classes.none
              }
            >
              {props.match.awayTeam.name}
            </span>
          </div>
        </div>
      </div>

      <div className={classes.score}>
        {props.match.goals > 0 && (
          <div className={classes.playerGoals}>
            <SportsSoccerIcon fontSize="small"></SportsSoccerIcon>
            <div className={classes.goalNumber}>{props.match.goals}</div>
          </div>
        )}
        <div className={classes.playerMinutes}>
          <p>{props.match.minutes}'</p>
        </div>
        <div className={classes.scoreGoals}>
          <h3>{props.match.homeTeamGoals}</h3>
          <h3>{props.match.awayTeamGoals}</h3>
        </div>
      </div>
    </div>
  );
};

export default PlayerResultCard;
