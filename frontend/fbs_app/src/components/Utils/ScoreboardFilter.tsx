import React from "react";
import Modal from "@mui/material/Modal";
import classes from "./styles/Filters.module.css";

const ScoreboardFilter = (props) => {
  return (
    <div className={classes.backGround}>
      <div className={classes.modal}>
        <button onClick={props.closeFilters}>X</button>
      </div>
    </div>
  );
};

export default ScoreboardFilter;
