import React from "react";
import classes from "./Results.module.css";
import dayjs from "dayjs";

const ResultCard = (props: any) => {
  return (
    <div className={classes.result} key={props.match.id}>
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
        <p>{props.match.homeTeamGoals}</p>
        <p>{props.match.awayTeamGoals}</p>
      </div>
    </div>
  );
};

export default ResultCard;
