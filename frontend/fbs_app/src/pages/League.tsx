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
import dayjs, { Dayjs } from "dayjs";
import PrintIcon from "@mui/icons-material/Print";
import JsPDF from "jspdf";
import html2canvas from "html2canvas";

const gameweeks = Array.from({ length: 38 }, (_, i) => {
  return { label: i + 1, value: i + 1 };
});

const minutesFH = Array.from({ length: 46 }, (_, i) => {
  return { label: i, value: i };
});

const minutesSH = Array.from({ length: 46 }, (_, i) => {
  return { label: i + 45, value: i + 45 };
});

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
  const [toggleFilterDate, setToggleFilterDate] = useState(true);
  const [toggleFilterMinutes, setToggleFilterMinutes] = useState(true);
  const [toggleFilterGameweeks, setToggleFilterGameweeks] = useState(true);
  const [toggleFilterGameeweekNumber, setToggleFilterGameeweekNumber] =
    useState(true);
  const [toggleFilterSubset, setToggleFilterSubset] = useState(true);
  const [teamList, setTeamList] = useState<any[]>([]);

  //filters
  const [teamSubset, setTeamSubset] = useState<any[]>([]);
  const [dateFilterUpperLimit, setDateFilterUpperLimit] =
    React.useState<Dayjs | null>(dayjs(Date.now()));
  const [dateFilterLowerLimit, setDateFilterLowerLimit] =
    React.useState<Dayjs | null>(dayjs(Date.now()));
  const [gwNumberFilter, setGwNumberFilter] = useState({
    label: 38,
    value: 38,
  });
  const [gwRangeFilterLowerLimit, setGwRangeFilterLowerLimit] = useState({
    label: 1,
    value: 1,
  });
  const [gwRangeFilterUpperLimit, setGwRangeFilterUpperLimit] = useState({
    label: 38,
    value: 38,
  });

  const [minutesRangeFilterLowerLimitFH, setMinutesRangeFilterLowerLimitFH] =
    useState({ label: 1, value: 1 });
  const [minutesRangeFilterUpperLimitFH, setMinutesRangeFilterUpperLimitFH] =
    useState({ label: 45, value: 45 });
  const [minutesRangeFilterLowerLimitSH, setMinutesRangeFilterLowerLimitSH] =
    useState({ label: 45, value: 45 });
  const [minutesRangeFilterUpperLimitSH, setMinutesRangeFilterUpperLimitSH] =
    useState({ label: 90, value: 90 });

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
        let subset = [];
        data.map((team) => subset.push(team.id));
        setTeamSubset(subset);
      })
      .catch((error) => {
        alert(error);
      });
  };

  const handleCheck = (event: any) => {
    const teamId = parseInt(event.target.value);
    var updatedList = [...teamSubset];
    if (event.target.checked) {
      updatedList = [...teamSubset, teamId];
    } else {
      updatedList.splice(teamSubset.indexOf(teamId), 1);
    }
    setTeamSubset(updatedList);
  };

  const applyFilterHandler = () => {
    setIsLoading(true);
    fetch(
      "http://localhost:5271/api/seasons/" +
        selectedSeason?.value +
        "/filteredTable",
      {
        method: "POST",
        body: JSON.stringify({
          goalsMinuteFilter: {
            lowerLimitFirstHalf: minutesRangeFilterLowerLimitFH?.value,
            upperLimitFirstHalf: minutesRangeFilterUpperLimitFH.value,
            extraTimeIncludedFirstHalf: true,
            lowerLimitSecondHalf: minutesRangeFilterLowerLimitSH.value,
            upperLimitSecondHalf: minutesRangeFilterUpperLimitSH.value,
            extraTimeIncludedSecondHalf: true,
          },
          dateFilter: {
            lowerLimit: dayjs(dateFilterLowerLimit).format("YYYY-MM-DD"),
            upperLimit: dayjs(dateFilterUpperLimit).format("YYYY-MM-DD"),
          },
          gameweeksFilter: {
            lowerLimit: gwRangeFilterLowerLimit?.value,
            upperLimit: gwRangeFilterUpperLimit?.value,
          },
          playedGameweeksFilter: {
            playedGameweeks: gwNumberFilter?.value,
          },
          teamsSubsetFilter: {
            ids: teamSubset,
          },
        }),
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
        setScoreBoard(data);
        setIsLoading(false);
      })
      .catch((error) => {
        alert(error);
      });
  };

  const generatePDF = () => {
    const input = document.getElementById("report");
    html2canvas(input).then((canvas) => {
      const imgData = canvas.toDataURL("image/png");
      const pdf = new JsPDF();
      pdf.addImage(imgData, "PNG", 0, 0, 210, 300);
      pdf.save("download.pdf");
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
          className={
            !isScoreboard
              ? classes.leagueMenuItemSelected
              : classes.leagueMenuItem
          }
          onClick={() => setIsScoreboard(false)}
        >
          Matches
        </div>
        <div
          className={
            isScoreboard
              ? classes.leagueMenuItemSelected
              : classes.leagueMenuItem
          }
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
                  {matches?.map((match, index) => (
                    <ResultCard match={match} key={index}></ResultCard>
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
                <div className={classes.scoreBoard_filtersContainer}>
                  {authCtx.role === "ADMIN" && (
                    <div className={classes.filterButton} onClick={generatePDF}>
                      <PrintIcon></PrintIcon>
                    </div>
                  )}
                  {authCtx.isLoggedIn && (
                    <div
                      className={classes.filterButton}
                      onClick={() => {
                        handleOpen();
                        fetchTeamList();
                      }}
                    >
                      <FilterAltIcon></FilterAltIcon>
                    </div>
                  )}
                </div>
              </div>
              {toggleFilters && (
                <ScoreboardFilter
                  closeFilters={closeFilters}
                ></ScoreboardFilter>
              )}
              {scoreBoard.length > 0 && (
                <div className={classes.scoreboard} id="report">
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
                        <tr key={team.id}>
                          <td>
                            <span
                              className={
                                scoreBoard.length == 20
                                  ? index === 0 ||
                                    index === 1 ||
                                    index === 2 ||
                                    index === 3
                                    ? classes.first
                                    : index === 4
                                    ? classes.second
                                    : index === 17 ||
                                      index === 18 ||
                                      index === 19
                                    ? classes.last
                                    : classes.other
                                  : classes.none
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
                            value={dateFilterLowerLimit}
                            onChange={(newValue) => {
                              console.log(newValue);
                              setDateFilterLowerLimit(newValue);
                            }}
                          />
                        </LocalizationProvider>
                      </div>
                      <div className={classes.dateFilterInput}>
                        <span className={classes.dateSpan}>To: </span>
                        <LocalizationProvider dateAdapter={AdapterDayjs}>
                          <DatePicker
                            slotProps={{ textField: { size: "small" } }}
                            value={dateFilterUpperLimit}
                            onChange={(newValue) => {
                              console.log(newValue);
                              setDateFilterUpperLimit(newValue);
                            }}
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
                        <Select
                          defaultValue={gwRangeFilterLowerLimit}
                          options={gameweeks}
                          onChange={setGwRangeFilterLowerLimit}
                        ></Select>
                      </div>
                      <div className={classes.dateFilterInput}>
                        <span className={classes.dateSpan}>To: </span>
                        <Select
                          defaultValue={gwRangeFilterUpperLimit}
                          options={gameweeks}
                          onChange={setGwRangeFilterUpperLimit}
                        ></Select>
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
                        <Select
                          defaultValue={minutesRangeFilterLowerLimitFH}
                          options={minutesFH}
                          maxMenuHeight={200}
                          onChange={setMinutesRangeFilterLowerLimitFH}
                        ></Select>
                      </div>
                      <div className={classes.dateFilterInput}>
                        <span className={classes.dateSpan}>From: </span>
                        <Select
                          defaultValue={minutesRangeFilterUpperLimitFH}
                          options={minutesFH}
                          maxMenuHeight={200}
                          onChange={setMinutesRangeFilterUpperLimitFH}
                        ></Select>
                      </div>

                      <div>Second half</div>
                      <div className={classes.dateFilterInput}>
                        <span className={classes.dateSpan}>From: </span>
                        <Select
                          defaultValue={minutesRangeFilterLowerLimitSH}
                          options={minutesSH}
                          maxMenuHeight={200}
                          onChange={setMinutesRangeFilterLowerLimitSH}
                        ></Select>
                      </div>
                      <div className={classes.dateFilterInput}>
                        <span className={classes.dateSpan}>From: </span>
                        <Select
                          defaultValue={minutesRangeFilterUpperLimitSH}
                          options={minutesSH}
                          maxMenuHeight={200}
                          onChange={setMinutesRangeFilterUpperLimitSH}
                        ></Select>
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
                        <Select
                          defaultValue={gwNumberFilter}
                          options={gameweeks}
                          maxMenuHeight={200}
                          onChange={setGwNumberFilter}
                        ></Select>
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
                          <input
                            type="checkBox"
                            defaultChecked
                            value={team.id}
                            onChange={handleCheck}
                          ></input>
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
              <div className={classes.centerContainer}>
                <button
                  className={classes.applyFiltersButton}
                  onClick={() => {
                    applyFilterHandler();
                    handleClose();
                  }}
                >
                  Filter
                </button>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
    </div>
  );
};

export default League;
