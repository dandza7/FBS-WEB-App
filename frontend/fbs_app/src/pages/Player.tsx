import React from "react";
import classes from "./styles/Player.module.css";
import { useState, useEffect, useContext } from "react";
import { useParams } from "react-router";
import { useNavigate } from "react-router";
import PlayerResultCard from "../components/Results/PlayerResultCard";
import Pagination from "../components/Utils/Pagination";
import AuthContext from "../store/auth-context";
import Modal from "@mui/material/Modal";
import Box from "@mui/material/Box";
import { LocalizationProvider } from "@mui/x-date-pickers/LocalizationProvider";
import dayjs, { Dayjs } from "dayjs";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import { DatePicker } from "@mui/x-date-pickers";
import CloseIcon from "@mui/icons-material/Close";
import Select from "react-select";
import AddIcon from "@mui/icons-material/Add";
import EditIcon from "@mui/icons-material/Edit";

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
  const [selectedEngagementStart, setSelectedEngagementStart] =
    React.useState<Dayjs | null>(dayjs(Date.now()));
  const [selectedEngagementEnd, setSelectedEngagementEnd] =
    React.useState<Dayjs | null>(dayjs(Date.now()));
  const [selectedTeamEngagement, setSelectedTeamEngagement] = useState(null);
  const [selectedDeleteEngagement, setSelectedDeleteEngagement] =
    useState(null);
  const [openDeleteEngagement, setOpenDeleteEngagement] = useState(false);
  const handleChangeSelectedTeamEngagement = (selected) => {
    setSelectedTeamEngagement(selected);
  };

  const handleOpen = () => {
    setOpen(true);
  };
  const handleClose = () => {
    setOpen(false);
  };

  const handleOpenDeleteEngagement = () => {
    setOpenDeleteEngagement(true);
  };
  const handleCloseDeleteEngagement = () => {
    setOpenDeleteEngagement(false);
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
            image: `data:image/png;base64,${item.logo}`,
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
    fetchPlayer();
  }, []);

  const fetchPlayer = () => {
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
  };

  useEffect(() => {
    fetchEngagements();
  }, []);

  const fetchEngagements = () => {
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
  };

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

  const handleAddTeamEngagement = () => {
    fetch("http://localhost:5271/api/players/engagement", {
      method: "POST",
      body: JSON.stringify({
        playerId: player.id,
        teamId: selectedTeamEngagement.value,
        startDate: dayjs(selectedEngagementStart).format("YYYY-MM-DD"),
        endDate: dayjs(selectedEngagementEnd).format("YYYY-MM-DD"),
      }),
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((res) => {})
      .then((data) => {
        handleClose();
        fetchEngagements();
        setshowMaches(false);
      })
      .catch((error) => {
        alert(error);
      });
  };

  const handleDeleteEngagement = () => {
    fetch(
      `http://localhost:5271/api/players/${player.id}/engagement/${selectedDeleteEngagement.id}`,
      {
        method: "DELETE",
        headers: {
          "Content-Type": "application/json",
          Authorization: "Bearer " + authCtx.token,
        },
      }
    )
      .then((res) => {
        handleCloseDeleteEngagement();
        fetchEngagements();
        setshowMaches(false);
      })
      .catch((error) => {
        alert(error);
      });
  };

  return (
    <div className={classes.player}>
      <div className={classes.whiteContainerTitle}>
        <div className={classes.playerInfoContainer}>
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
          {authCtx.role === "ADMIN" && (
            <div>
              <EditIcon
                fontSize="s,a;;"
                className={classes.editPlayerButton}
                onClick={() => {
                  navigate("/update-player/" + player.id);
                }}
              >
                Edit
              </EditIcon>
            </div>
          )}
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
                          <div
                            onClick={() => {
                              handleOpen();
                              fetchTeamList();
                            }}
                          >
                            <AddIcon
                              fontSize="small"
                              className={classes.engagementsTable_addIcon}
                            ></AddIcon>
                          </div>
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
                        {authCtx.role == "ADMIN" && (
                          <td>
                            <div
                              onClick={() => {
                                setSelectedDeleteEngagement(engagament);
                                handleOpenDeleteEngagement();
                              }}
                              className={classes.engagementsTable_deleteIcon}
                            >
                              <CloseIcon fontSize="small"></CloseIcon>
                            </div>
                          </td>
                        )}
                      </tr>
                    ))}
                  </tbody>
                </table>
              </div>
            </>
          ) : authCtx.role == "ADMIN" ? (
            <div className={classes.modalButtonContainer}>
              <button
                className={classes.modalAddEngagementButton}
                onClick={() => {
                  handleOpen();
                  fetchTeamList();
                }}
              >
                Add Engagement
              </button>
            </div>
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
                      <Select
                        options={allTeams}
                        className={classes.teamSelect}
                        defaultValue={selectedTeamEngagement}
                        onChange={handleChangeSelectedTeamEngagement}
                        formatOptionLabel={(team: any) => (
                          <div className={classes.teamSelect_optionContainer}>
                            <img
                              src={team.image}
                              className={classes.teamSelect_logo}
                              alt="country-image"
                            />
                            <span>{team.label}</span>
                          </div>
                        )}
                      ></Select>
                    </div>
                    <div className={classes.dateFilterInput}>
                      <span className={classes.dateSpan}>From: </span>
                      <LocalizationProvider dateAdapter={AdapterDayjs}>
                        <DatePicker
                          className={classes.teamSelect}
                          slotProps={{ textField: { size: "small" } }}
                          value={selectedEngagementStart}
                          onChange={(newValue) => {
                            setSelectedEngagementStart(newValue);
                          }}
                        />
                      </LocalizationProvider>
                    </div>
                    <div className={classes.dateFilterInput}>
                      <span className={classes.dateSpan}>To: </span>
                      <LocalizationProvider dateAdapter={AdapterDayjs}>
                        <DatePicker
                          className={classes.teamSelect}
                          slotProps={{ textField: { size: "small" } }}
                          value={selectedEngagementEnd}
                          onChange={(newValue) => {
                            setSelectedEngagementEnd(newValue);
                          }}
                        />
                      </LocalizationProvider>
                    </div>
                  </div>
                </div>
                <div className={classes.modalButtonContainer}>
                  <button
                    className={classes.modalAddEngagementButton}
                    onClick={handleAddTeamEngagement}
                  >
                    Add
                  </button>
                </div>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
      <Modal
        open={openDeleteEngagement}
        onClose={handleCloseDeleteEngagement}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className={classes.modalContainerDelete}>
            <div className={classes.modalHeader}>
              <h2>Delete engagement</h2>
              <button
                onClick={handleCloseDeleteEngagement}
                className={classes.closeModalButton}
              >
                <CloseIcon></CloseIcon>
              </button>
            </div>
            <div className={classes.modalBody}>
              <div>Are you sure you want to delete this engagement?</div>
              <br></br>
              <h4>Player name: {player?.name}</h4>
              <h4>Team name: {selectedDeleteEngagement?.name}</h4>
              <h4>
                Period:{" "}
                {dayjs(selectedDeleteEngagement?.startDate).format(
                  "DD.MM.YYYY"
                )}{" "}
                -{" "}
                {dayjs(selectedDeleteEngagement?.endDate).format("DD.MM.YYYY")}
              </h4>

              <br></br>
              <div className={classes.modalButtonContainer}>
                <button
                  className={classes.modalAddEngagementButton}
                  onClick={handleDeleteEngagement}
                >
                  Confirm
                </button>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
    </div>
  );
};

export default Player;
