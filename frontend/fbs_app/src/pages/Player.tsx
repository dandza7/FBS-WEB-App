import React from "react";
import classes from "./styles/Player.module.css";
import { useState, useEffect } from "react";
import { useParams } from "react-router";
import dayjs from "dayjs";
import { useNavigate } from "react-router";
import PlayerResultCard from "../components/Results/PlayerResultCard";
import Pagination from "../components/Utils/Pagination";

const Player = () => {
  const [showMatches, setshowMaches] = useState(true);
  const [player, setPlayer] = useState(null);
  const [playerEngagements, setPlayerEngagements] = useState(null);
  const [matches, setMatches] = useState<any[]>([]);
  const navigate = useNavigate();
  const [totalMatchCount, setTotalMatchCount] = useState(null);
  const { id } = useParams();
  const pageSize = 5;
  const [selectedPage, setSelectedPage] = useState(1);

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
        getMatches();
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

  const getMatches = () => {
    fetch(
      `http://localhost:5271/api/players/${id}/matches/${selectedPage}/${pageSize}`,
      {
        method: "GET",
        headers: {
          "Content-Type": "application/json",
        },
      }
    )
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        console.log(data);
        setMatches(data.entities);
        setTotalMatchCount(data.totalCount);
      })
      .catch((error) => {
        alert(error);
      });
  };

  const changePage = (page: number) => {
    setSelectedPage(page);
  };

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
          {matches?.length > 0 ? (
            <>
              <h3>Matches</h3>
              <br></br>
              <div className={classes.results}>
                {matches?.map((match) => (
                  <PlayerResultCard match={match}></PlayerResultCard>
                ))}
              </div>
              {totalMatchCount > pageSize && (
                <Pagination
                  change={changePage}
                  totalCount={totalMatchCount}
                  pageSize={pageSize}
                  currentPage={selectedPage}
                ></Pagination>
              )}
            </>
          ) : (
            <div>There is no data for this player.</div>
          )}
        </div>
      )}
      {!showMatches && (
        <div className={classes.whiteContainer}>
          {playerEngagements.length > 0 ? (
            <>
              <h3>Teams</h3>
              <br></br>
              <div className={classes.engagaments}>
                <table className={classes.engagamentsTable}>
                  <thead>
                    <tr>
                      <th>Team</th>
                      <th>Time in team</th>
                    </tr>
                  </thead>
                  <tbody>
                    {playerEngagements?.map((engagament: any) => (
                      <tr>
                        <td>
                          <div className={classes.imgNameColumn}>
                            {engagament?.logo && (
                              <img
                                className={classes.tableFlag}
                                src={`data:image/png;base64,${engagament?.logo}`}
                              ></img>
                            )}
                            <span
                              className={classes.engagamentName}
                              onClick={() => {
                                navigate("/team/" + engagament.teamId);
                              }}
                            >
                              {engagament?.name}
                            </span>
                          </div>
                        </td>
                        <td>
                          {dayjs(engagament.startDate).format("MM.YYYY")}-
                          {dayjs(engagament.endDate).format("MM.YYYY")}
                        </td>
                      </tr>
                    ))}
                  </tbody>
                </table>
              </div>
            </>
          ) : (
            <div>There is no data for this player.</div>
          )}
        </div>
      )}
    </div>
  );
};

export default Player;
