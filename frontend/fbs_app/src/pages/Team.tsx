import React from "react";
import classes from "./styles/Team.module.css";
import { useState, useEffect } from "react";
import Players from "../components/Players/Players";
import Select from "react-select";
import { useParams } from "react-router";
import Teams from "./Teams";
import dayjs from "dayjs";
import { useNavigate } from "react-router";
import Pagination from "../components/Utils/Pagination";
import ResultCard from "../components/Results/ResultCard";

const Team = () => {
  const [tab, setTab] = useState("Matches");

  const [team, setTeam] = useState(null);
  const [squad, setSquad] = useState<any[]>([]);
  const [staff, setStaff] = useState<any[]>([]);
  const { id } = useParams();
  const [matches, setMatches] = useState<any[]>([]);
  const [allSeasons, setAllSeasons] = useState<any[]>([]);
  const navigate = useNavigate();
  const [totalMatchCount, setTotalMatchCount] = useState(null);
  const [selectedPage, setSelectedPage] = useState(1);
  const [selectedSeason, setSelectedSeason] = useState(null);
  const pageSize = 5;

  const getTeamMatches = () => {
    console.log(selectedSeason);
    fetch(
      `http://localhost:5271/api/teams/${id}/matches/${selectedSeason?.value}/${selectedPage}/${pageSize}`,
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
        setMatches(data.entities);
        setTotalMatchCount(data.totalCount);
      })
      .catch((error) => {
        alert(error);
      });
  };

  useEffect(() => {
    getTeamMatches();
  }, [selectedPage, selectedSeason]);

  useEffect(() => {
    console.log(selectedSeason?.value);
    fetch(
      "http://localhost:5271/api/teams/" +
        id +
        "/squad/" +
        selectedSeason?.value,
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
        setSquad(data);
      })
      .catch((error) => {
        alert(error);
      });
  }, [selectedSeason]);

  useEffect(() => {
    fetch(
      "http://localhost:5271/api/teams/" +
        id +
        "/staff/" +
        selectedSeason?.value,
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
        const staff = [];
        console.log(data);
        staff.push(data[0]?.staff);
        setStaff(staff);
      })
      .catch((error) => {
        alert(error);
      });
  }, [selectedSeason]);

  useEffect(() => {
    fetch("http://localhost:5271/api/teams/" + id + "/detailed", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        setTeam(data);
        let seasons = [];
        data.seasons.map((season) => {
          seasons.push({
            value: season.id,
            label: season.league + " " + season.year,
          });
        });
        console.log(seasons[0]);
        setAllSeasons(seasons);
        setSelectedSeason(seasons[0]);
      })
      .catch((error) => {
        alert(error);
      });
  }, []);

  const changePage = (page: number) => {
    setSelectedPage(page);
  };

  const handleChangeSeason = (selected) => {
    setSelectedSeason(selected);
    setSelectedPage(1);
  };

  return (
    <div className={classes.team}>
      <div className={classes.whiteContainerTitle}>
        <div className={classes.teamInfo}>
          <div>
            {team?.logo && (
              <img
                className={classes.teamImage}
                src={`data:image/png;base64,${team?.logo}`}
              ></img>
            )}
          </div>
          <div className={classes.basicInfo}>
            <h2>{team?.name}</h2>
            <p>Stadium : {team?.stadiumName}</p>
          </div>
        </div>
      </div>
      <div className={classes.teamMenu}>
        <div
          className={
            tab === "Matches"
              ? classes.teamMenuItemSelected
              : classes.teamMenuItem
          }
          onClick={() => {
            setTab("Matches");
            getTeamMatches();
          }}
        >
          Matches
        </div>
        <div
          className={
            tab === "Squad"
              ? classes.teamMenuItemSelected
              : classes.teamMenuItem
          }
          onClick={() => setTab("Squad")}
        >
          Squad
        </div>
      </div>
      <div className={classes.seasonContainer}>
        <div className={classes.seasonSelectContainer}>
          <span>Season:</span>
          {selectedSeason && (
            <Select
              defaultValue={selectedSeason}
              onChange={handleChangeSeason}
              options={allSeasons}
              placeholder="Select season"
            />
          )}
        </div>
      </div>

      {tab === "Squad" && (
        <div className={classes.whiteContainerInfo}>
          {selectedSeason ? (
            <Players squad={squad} staff={staff}></Players>
          ) : (
            <div>Select season</div>
          )}
        </div>
      )}
      {tab === "Matches" && (
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
      )}
    </div>
  );
};
export default Team;
