import React from "react";
import classes from "./TeamCard.module.css";

const TeamCard = (props) => {
  return (
    <div className={classes.team}>
      <img
        src={`data:image/png;base64,${props.team.logo}`}
        className={classes.logo}
      ></img>
      <p>{props.team.name}</p>
      <img
        src={`data:image/png;base64,${props.team.flag}`}
        className={classes.flag}
      ></img>
    </div>
  );
};

export default TeamCard;
