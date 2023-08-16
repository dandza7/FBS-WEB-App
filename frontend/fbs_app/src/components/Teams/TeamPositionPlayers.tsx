import React from "react";
import classes from "./TeamPositionPlayers.module.css";
import dayjs from "dayjs";
import { useNavigate } from "react-router";
const TeamPositionPlayers = (props) => {
  const navigate = useNavigate();
  function getAge(dateString: Date) {
    var today = new Date();
    var birthDate = new Date(dayjs(dateString).format("MMM D, YYYY"));
    var age = today.getFullYear() - birthDate.getFullYear();
    var m = today.getMonth() - birthDate.getMonth();
    if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
      age--;
    }
    return age;
  }

  return (
    <div className={classes.positionContainer}>
      <h3>{props.position}</h3>

      <div className={classes.players}>
        <table className={classes.playersTable}>
          <thead>
            <tr>
              <th>Name</th>
              <th>Age</th>
            </tr>
          </thead>
          <tbody>
            {props.players?.map((player) => (
              <tr key={player?.id}>
                <td>
                  <div className={classes.imgNameColumn}>
                    {player?.countryFlag && (
                      <img
                        className={classes.tableFlag}
                        src={`data:image/png;base64,${player?.countryFlag}`}
                      ></img>
                    )}
                    <span
                      className={classes.playerName}
                      onClick={() => {
                        navigate("/player/" + player.id);
                      }}
                    >
                      {" "}
                      {player?.name}
                    </span>
                  </div>
                </td>
                <td>{getAge(player?.birthDate)}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
};

export default TeamPositionPlayers;
