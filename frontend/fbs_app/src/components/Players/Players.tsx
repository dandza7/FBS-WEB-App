import React from "react";
import classes from "./Players.module.css";
import { useEffect, useState } from "react";
import TeamPositionPlayers from "../Teams/TeamPositionPlayers";

const Players = (props) => {
  const [defenders, setDefenders] = useState<any[]>([]);
  const [midfielders, setMidfielders] = useState<any[]>([]);
  const [attackers, setAttackers] = useState<any[]>([]);
  const [goalKeepers, setGoalkeepers] = useState<any[]>([]);

  useEffect(() => {
    const defend = props.squad.filter(
      (player: any) => player.position == "Defender"
    );
    const mid = props.squad.filter(
      (player: any) => player.position == "Midfielder"
    );
    const attack = props.squad.filter(
      (player: any) => player.position == "Attacker"
    );
    const goalkeepers = props.squad.filter(
      (player: any) => player.position == "Goalkeeper"
    );
    setGoalkeepers(goalkeepers);
    setDefenders(defend);
    setMidfielders(mid);
    setAttackers(attack);
  }, [props]);

  return (
    <>
      {props.squad.length > 0 ? (
        <div className={classes.positions}>
          <div className={classes.positionContainer}>
            <TeamPositionPlayers
              position={"Goalkeepers"}
              players={goalKeepers}
            ></TeamPositionPlayers>
          </div>
          <div className={classes.positionContainer}>
            <TeamPositionPlayers
              position={"Defenders"}
              players={defenders}
            ></TeamPositionPlayers>
          </div>
          <div className={classes.positionContainer}>
            <TeamPositionPlayers
              position={"Midfielders"}
              players={midfielders}
            ></TeamPositionPlayers>
          </div>
          <div className={classes.positionContainer}>
            <TeamPositionPlayers
              position={"Attackers"}
              players={attackers}
            ></TeamPositionPlayers>
          </div>
          <div className={classes.positionContainer}>
            <TeamPositionPlayers
              position={"Staff"}
              players={props.staff}
            ></TeamPositionPlayers>
          </div>
        </div>
      ) : (
        <div>
          <span>There is no data for this season.</span>
        </div>
      )}
    </>
  );
};

export default Players;
