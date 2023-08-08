import React from "react";
import classes from "./PlayerCard.module.css";

const PlayerCard = (props) => {
  return (
    <div className={classes.player}>
      <img
        src={
          props.player.photo
            ? `data:image/png;base64,${props.player.photo}`
            : "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_960_720.png"
        }
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
