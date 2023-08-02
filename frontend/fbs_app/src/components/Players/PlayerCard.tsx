import React from "react";
import classes from "./PlayerCard.module.css";

const PlayerCard = (props) => {
  return (
    <div className={classes.player}>
      <img
        src={`data:image/png;base64,${props.player.photo}`}
        className={classes.photo}
      ></img>
      <p>{props.player.name}</p>
      <img
        src={`data:image/png;base64,${props.player.countryFlag}`}
        className={classes.flag}
      ></img>
    </div>
  );
};

export default PlayerCard;
