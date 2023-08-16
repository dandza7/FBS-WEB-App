import React from "react";
import classes from "./styles/League.module.css";
import { useState, useEffect, useContext } from "react";
import Select from "react-select";
import ReactLoading from "react-loading";
import { useNavigate, useParams } from "react-router";
import AuthContext from "../store/auth-context";
import Pagination from "../components/Utils/Pagination";
import ResultCard from "../components/Results/ResultCard";
import FilterAltIcon from "@mui/icons-material/FilterAlt";
import ScoreboardFilter from "../components/Utils/ScoreboardFilter";
import Modal from "@mui/material/Modal";
import Box from "@mui/material/Box";
import { LocalizationProvider } from "@mui/x-date-pickers/LocalizationProvider";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import { DatePicker } from "@mui/x-date-pickers";
import CloseIcon from "@mui/icons-material/Close";
const League = () => {
  const [isScoreboard, setIsScoreboard] = useState(false);
  const [selectedSeason, setSelectedSeason] = useState(null);
  const [scoreBoard, setScoreBoard] = useState<any[]>([]);
  const [teamCount, setTeamCount] = useState(null);
  const [league, setLeague] = useState(null);
  const [isLoading, setIsLoading] = useState(false);
  const [seasons, setSeasons] = useState<any[]>([]);
  const [matches, setMatches] = useState<any[]>([]);
  const [totalMatchCount, setTotalMatchCount] = useState(null);
  const [selectedPage, setSelectedPage] = useState(1);
  const pageSize = 5;
  const authCtx = useContext(AuthContext);
  const [toggleFilters, setToggleFilters] = useState(false);
  const [open, setOpen] = useState(false);
  const [toggleFilterDate, setToggleFilterDate] = useState(false);
  const [toggleFilterMinutes, setToggleFilterMinutes] = useState(false);
  const [toggleFilterGameweeks, setToggleFilterGameweeks] = useState(false);
  const [toggleFilterGameeweekNumber, setToggleFilterGameeweekNumber] =
    useState(false);
  const [toggleFilterSubset, setToggleFilterSubset] = useState(false);
  const [teamList, setTeamList] = useState<any[]>([]);
  const navigate = useNavigate();
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

  const changePage = (page: number) => {
    setSelectedPage(page);
  };

  const { id } = useParams();
  const handleChangeSeason = (selected) => {
    setSelectedSeason(selected);
    setSelectedPage(1);
  };

  const closeFilters = () => {
    setToggleFilters(false);
  };

  useEffect(() => {
    fetch("http://localhost:5271/api/leagues/" + id, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        setLeague(data);
        let seasons = [];
        data.seasons.map((season) => {
          seasons.push({
            value: season.id,
            label: season.league + " " + season.year,
          });
        });
        console.log(seasons[0]);
        setSeasons(seasons);
        setSelectedSeason(seasons[0]);
      })
      .catch((error) => {
        alert(error);
      });
  }, []);

  useEffect(() => {
    if (selectedSeason?.value) {
      setIsLoading(true);
      fetch(
        "http://localhost:5271/api/seasons/" + selectedSeason?.value + "/table",
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
          setScoreBoard(data);
          setTeamCount(data.length);
          setIsLoading(false);
        })
        .catch((error) => {
          alert(error);
        });
    } else {
      return;
    }
  }, [selectedSeason]);

  useEffect(() => {
    fetch(
      "http://localhost:5271/api/seasons/" +
        selectedSeason?.value +
        "/matches/" +
        selectedPage +
        "/" +
        pageSize,
      {
        method: "GET",
        headers: {
          "Content-Type": "application/json",
          Authorization: "Bearer " + authCtx.token,
        },
      }
    )
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        setMatches(data.entities);
        setTotalMatchCount(data.totalCount);
      })
      .catch((error) => {
        alert(error);
      });
  }, [selectedSeason, selectedPage]);

  const handleOpen = () => {
    setOpen(true);
  };
  const handleClose = () => {
    setOpen(false);
  };

  const fetchTeamList = () => {
    fetch(
      "http://localhost:5271/api/seasons/" + selectedSeason?.value + "/teams",
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
        setTeamList(data);
      })
      .catch((error) => {
        alert(error);
      });
  };

  return (
    <div className={classes.league}>
      <div className={classes.whiteContainerTitle}>
        <h2>{league?.name}</h2>
        <img
          className={classes.leagueFlag}
          src={`data:image/png;base64,${league?.flag}`}
        ></img>
      </div>
      <div className={classes.leagueMenu}>
        <div
          className={classes.leagueMenuItem}
          onClick={() => setIsScoreboard(false)}
        >
          Matches
        </div>
        <div
          className={classes.leagueMenuItem}
          onClick={() => setIsScoreboard(true)}
        >
          Scoreboard
        </div>
      </div>
      <div className={classes.seasonContainer}>
        {seasons.length > 0 ? (
          <div className={classes.seasonSelectContainer}>
            <span>Season:</span>
            {selectedSeason && (
              <Select
                defaultValue={selectedSeason}
                onChange={handleChangeSeason}
                options={seasons}
                placeholder="Select season"
              />
            )}
          </div>
        ) : (
          <div>There is no data for this league.</div>
        )}
      </div>
      {!isScoreboard && (
        <div className={classes.whiteContainer}>
          <div className={classes.whiteContainerInfo}>
            {matches?.length > 0 ? (
              <>
                <h3>Matches</h3>
                <br></br>
                <div className={classes.results}>
                  {matches?.map((match) => (
                    <ResultCard match={match}></ResultCard>
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
              <div>There are no matches for this season.</div>
            )}
          </div>
        </div>
      )}
      {isScoreboard && (
        <div className={classes.whiteContainer}>
          {isLoading ? (
            <div className={classes.loadingContainer}>
              <ReactLoading
                type={"spin"}
                color={"#1f2466"}
                height={30}
                width={30}
              />
            </div>
          ) : scoreBoard.length > 0 ? (
            <>
              <div className={classes.titleContainer}>
                <h3>Scoreboard</h3>
                <div
                  className={classes.filterButton}
                  onClick={() => {
                    fetchTeamList();
                    handleOpen();
                  }}
                >
                  <FilterAltIcon></FilterAltIcon>
                </div>
              </div>
              {toggleFilters && (
                <ScoreboardFilter
                  closeFilters={closeFilters}
                ></ScoreboardFilter>
              )}
              {scoreBoard.length > 0 && (
                <div className={classes.scoreboard}>
                  <table className={classes.leaguesTable}>
                    <thead>
                      <tr>
                        <th>#</th>
                        <th>Team</th>
                        <th>PG</th>
                        <th>W</th>
                        <th>D</th>
                        <th>L</th>
                        <th>GD</th>
                        <th>P</th>
                      </tr>
                    </thead>
                    <tbody>
                      {scoreBoard?.map((team, index) => (
                        <tr>
                          <td>
                            <span
                              className={
                                index === 0 ||
                                index === 1 ||
                                index === 2 ||
                                index === 3
                                  ? classes.first
                                  : index === 4
                                  ? classes.second
                                  : index === 17 || index === 18 || index === 19
                                  ? classes.last
                                  : classes.other
                              }
                            >
                              {`${index + 1}.`}{" "}
                            </span>
                          </td>
                          <td>
                            <div className={classes.imgNameColumn}>
                              {team?.logo && (
                                <img
                                  className={classes.teamLogo}
                                  src={`data:image/png;base64,${team?.logo}`}
                                ></img>
                              )}
                              <span
                                className={classes.scoreBoard_teamName}
                                onClick={() => {
                                  navigate("/team/" + team.teamId);
                                }}
                              >
                                {team?.name}
                              </span>
                            </div>
                          </td>

                          <td>{team?.wins + team?.draws + team?.losses}</td>
                          <td>{team?.wins}</td>
                          <td>{team?.draws}</td>
                          <td>{team?.losses}</td>
                          <td>
                            {team?.goalsScored}:{team?.goalsConceded}
                          </td>
                          <td>{team?.wins * 3 + team?.draws}</td>
                        </tr>
                      ))}
                    </tbody>
                  </table>
                </div>
              )}
            </>
          ) : (
            <div>There is no data for this season.</div>
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
              <h2>Filters</h2>
              <button
                onClick={handleClose}
                className={classes.closeModalButton}
              >
                <CloseIcon></CloseIcon>
              </button>
            </div>
            <div className={classes.modalBody}>
              <div className={classes.filters}>
                <div
                  className={classes.filterName}
                  onClick={() => setToggleFilterDate((prevState) => !prevState)}
                >
                  Filter by date
                </div>
                {toggleFilterDate && (
                  <div className={classes.filterContainer}>
                    <div>Choose the range of dates.</div>
                    <div className={classes.dateFilterInputs}>
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
                )}
                <div
                  onClick={() =>
                    setToggleFilterGameweeks((prevState) => !prevState)
                  }
                  className={classes.filterName}
                >
                  Filter by gameweeks
                </div>
                {toggleFilterGameweeks && (
                  <div className={classes.filterContainer}>
                    <div>Choose the range of dates.</div>
                    <div className={classes.dateFilterInputs}>
                      <div className={classes.dateFilterInput}>
                        <span className={classes.dateSpan}>From: </span>
                        <Select></Select>
                      </div>
                      <div className={classes.dateFilterInput}>
                        <span className={classes.dateSpan}>To: </span>
                        <Select></Select>
                      </div>
                    </div>
                  </div>
                )}
                <div
                  onClick={() =>
                    setToggleFilterMinutes((prevState) => !prevState)
                  }
                  className={classes.filterName}
                >
                  Filter by minutes of goals
                </div>
                {toggleFilterMinutes && (
                  <div className={classes.filterContainer}>
                    <div>Choose the range of minutes.</div>
                    <div className={classes.dateFilterInputs}>
                      <div>First half</div>
                      <div className={classes.dateFilterInput}>
                        <span className={classes.dateSpan}>From: </span>
                        <Select></Select>
                      </div>
                      <div className={classes.dateFilterInput}>
                        <span className={classes.dateSpan}>From: </span>
                        <Select></Select>
                      </div>

                      <div>Second half</div>
                      <div className={classes.dateFilterInput}>
                        <span className={classes.dateSpan}>From: </span>
                        <Select></Select>
                      </div>
                      <div className={classes.dateFilterInput}>
                        <span className={classes.dateSpan}>From: </span>
                        <Select></Select>
                      </div>
                    </div>
                  </div>
                )}
                <div
                  onClick={() =>
                    setToggleFilterGameeweekNumber((prevState) => !prevState)
                  }
                  className={classes.filterName}
                >
                  Filter by number of gameweeks
                </div>
                {toggleFilterGameeweekNumber && (
                  <div className={classes.filterContainer}>
                    <div>Choose the range of dates.</div>
                    <div className={classes.dateFilterInputs}>
                      <div className={classes.dateFilterInput}>
                        <span className={classes.dateSpan}>From: </span>
                        <Select></Select>
                      </div>
                    </div>
                  </div>
                )}
                <div
                  onClick={() =>
                    setToggleFilterSubset((prevState) => !prevState)
                  }
                  className={classes.filterName}
                >
                  Filter by teams subset
                </div>
                {toggleFilterSubset && (
                  <div className={classes.filterContainer}>
                    <div>Choose which teams to include.</div>
                    <div className={classes.dateFilterInputs}>
                      {teamList?.map((team) => (
                        <div className={classes.teamFilter_teamContainer}>
                          <input type="checkBox"></input>
                          <div className={classes.teamFilter_team}>
                            <img
                              className={classes.teamFilter_teamLogo}
                              src={`data:image/png;base64,${team?.logo}`}
                            ></img>
                            <div>{team?.name}</div>
                          </div>
                        </div>
                      ))}
                    </div>
                  </div>
                )}
              </div>
            </div>
          </div>
        </Box>
      </Modal>
    </div>
  );
};

export default League;
