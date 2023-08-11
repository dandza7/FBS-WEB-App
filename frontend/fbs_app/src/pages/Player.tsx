import React from "react";
import classes from "./styles/Player.module.css";
import { useState, useEffect } from "react";
import { useParams } from "react-router";
import dayjs from "dayjs";
const Player = () => {
  const [showMatches, setshowMaches] = useState(true);
  const [player, setPlayer] = useState(null);
  const [playerEngagements, setPlayerEngagements] = useState(null);

  const { id } = useParams();

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

  useEffect(() => {
    fetch("http://localhost:5271/api/players/" + id, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        setPlayer(data);
      })
      .catch((error) => {
        alert(error);
      });
  }, []);

  useEffect(() => {
    fetch("http://localhost:5271/api/players/" + id + "/engagements", {
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
        setPlayerEngagements(data);
      })
      .catch((error) => {
        alert(error);
      });
  }, []);

  return (
    <div className={classes.player}>
      <div className={classes.whiteContainerTitle}>
        <div className={classes.playerInfo}>
          <div>
            <img
              className={classes.playerImage}
              src={`data:image/png;base64,${player?.photo}`}
            ></img>
          </div>
          <div className={classes.basicInfo}>
            <h2>{player?.name}</h2>
            <div className={classes.playerCountry}>
              <img
                className={classes.flagImage}
                src={`data:image/png;base64,${player?.countryFlag}`}
              ></img>
              {player?.countryName}
            </div>

            <p>
              Age: {getAge(player?.birthDate)} (
              {dayjs(player?.birthDate).format("DD.MM.YYYY")})
            </p>
            <p>Position: {player?.position}</p>
          </div>
        </div>
      </div>
      <div className={classes.playerMenu}>
        <div
          className={
            showMatches
              ? classes.playerMenuItemSelected
              : classes.playerMenuItem
          }
          onClick={() => setshowMaches(true)}
        >
          Matches
        </div>
        <div
          className={
            !showMatches
              ? classes.playerMenuItemSelected
              : classes.playerMenuItem
          }
          onClick={() => setshowMaches(false)}
        >
          Teams
        </div>
      </div>
      {showMatches && (
        <div className={classes.whiteContainer}>
          <h3>Matches</h3>
          <br></br>
          <div className={classes.results}>
            <div className={classes.result}>
              <div className={classes.teamsDateContainer}>
                <div>
                  <p>25.08.2023.</p>
                </div>
                <div>
                  <p>Tim1</p>
                  <p className={classes.winner}>Tim1</p>
                </div>
              </div>

              <div className={classes.score}>
                <p>2</p>
                <p>1</p>
              </div>
            </div>
          </div>
        </div>
      )}
      {!showMatches && (
        <div className={classes.whiteContainer}>
          <h3>Teams</h3>
          <br></br>
          <div className={classes.scoreboard}>
            <table className={classes.scoreboardTable}>
              <thead>
                <tr>
                  <th>Team</th>
                  <th>Season</th>
                </tr>
              </thead>
              <tbody>
                {playerEngagements?.map((engagament) => (
                  <tr>
                    <td>
                      {" "}
                      <div className={classes.imgNameColumn}>
                        {engagament?.logo && (
                          <img
                            className={classes.tableFlag}
                            src={`data:image/png;base64,${engagament?.logo}`}
                          ></img>
                        )}
                        {engagament?.name}
                      </div>
                    </td>
                    <td>
                      {dayjs(engagament.startDate).format("YYYY")}/
                      {dayjs(engagament.endDate).format("YYYY")}
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        </div>
      )}
    </div>
  );
};

export default Player;
