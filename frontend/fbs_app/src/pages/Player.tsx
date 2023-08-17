import React from "react";
import classes from "./styles/Player.module.css";
import { useState, useEffect, useContext } from "react";
import { useParams } from "react-router";
import dayjs from "dayjs";
import { useNavigate } from "react-router";
import PlayerResultCard from "../components/Results/PlayerResultCard";
import Pagination from "../components/Utils/Pagination";
import AuthContext from "../store/auth-context";
import Modal from "@mui/material/Modal";
import Box from "@mui/material/Box";
import { LocalizationProvider } from "@mui/x-date-pickers/LocalizationProvider";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import { DatePicker } from "@mui/x-date-pickers";
import CloseIcon from "@mui/icons-material/Close";
import Select from "react-select";

const style = {
  position: "absolute" as "absolute",
  top: "50%",
  left: "50%",
  transform: "translate(-50%, -50%)",
  bgcolor: "background.paper",
  boxShadow: 24,
  borderRadius: 1,
  p: 2,
};

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
  const authCtx = useContext(AuthContext);
  const [open, setOpen] = useState(false);
  const [allTeams, setAllTeams] = useState<any[]>([]);
  const handleOpen = () => {
    setOpen(true);
  };
  const handleClose = () => {
    setOpen(false);
  };

  const fetchTeamList = () => {
    fetch("http://localhost:5271/api/teams", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        const allTeams: any = [];
        data.map((item: any) => {
          allTeams.push({
            value: item.id,
            label: item.name,
            image: `data:image/png;base64,${item.flag}`,
          });
        });
        setAllTeams(allTeams);
      })
      .catch((error) => {
        alert(error);
      });
  };

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

  useEffect(() => {
    getMatches();
  }, [selectedPage]);

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
                      {authCtx.role == "ADMIN" && (
                        <th>
                          <div onClick={handleOpen}>+</div>
                        </th>
                      )}
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
                          {dayjs(engagament.startDate).format("DD.MM.YYYY")}-
                          {dayjs(engagament.endDate).format("DD.MM.YYYY")}
                        </td>
                        {authCtx.role == "ADMIN" && <td></td>}
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
      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className={classes.modalContainer}>
            <div className={classes.modalHeader}>
              <h2>New engagement</h2>
              <button
                onClick={handleClose}
                className={classes.closeModalButton}
              >
                <CloseIcon></CloseIcon>
              </button>
            </div>
            <div className={classes.modalBody}>
              <div className={classes.filters}>
                <div className={classes.filterContainer}>
                  <div className={classes.dateFilterInputs}>
                    <div className={classes.dateFilterInput}>
                      <span className={classes.dateSpan}>Team: </span>
                      <Select></Select>
                    </div>
                    <div className={classes.dateFilterInput}>
                      <span className={classes.dateSpan}>From: </span>
                      <LocalizationProvider dateAdapter={AdapterDayjs}>
                        <DatePicker
                          slotProps={{ textField: { size: "small" } }}
                        />
                      </LocalizationProvider>
                    </div>
                    <div className={classes.dateFilterInput}>
                      <span className={classes.dateSpan}>To: </span>
                      <LocalizationProvider dateAdapter={AdapterDayjs}>
                        <DatePicker
                          slotProps={{ textField: { size: "small" } }}
                        />
                      </LocalizationProvider>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
    </div>
  );
};

export default Player;
