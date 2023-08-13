import React from "react";
import classes from "./TeamCard.module.css";

const TeamCard = (props) => {
  return (
    <div
      className={classes.team}
      onClick={() => {
        props.onClick(props.team.id);
      }}
    >
      <div className={classes.teamImageContainer}>
        <img
          src={`data:image/png;base64,${props.team.logo}`}
          className={classes.logo}
        ></img>
      </div>
      <p>{props.team.name}</p>
      <img
        src={`data:image/png;base64,${props.team.flag}`}
        className={classes.flag}
      ></img>
    </div>
  );
};

export default TeamCard;
