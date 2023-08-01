import React from "react";
import classes from "./styles/Team.module.css";
import { useState } from "react";
import Players from "../components/Players/Players";
import Select from "react-select";

const seasons = [
  { value: "2020/2021", label: "2020/2021" },
  { value: "2021/2022", label: "2021/2022" },
  { value: "2022/2023", label: "2022/2023" },
];

const Team = () => {
  const [tab, setTab] = useState("Stats");
  const [selectedSeason, setSelectedSeason] = useState(null);

  return (
    <div className={classes.player}>
      <div className={classes.whiteContainerTitle}>
        <div className={classes.playerInfo}>
          <div>
            <img
              className={classes.playerImage}
              src="https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Juventus_FC_2017_icon_%28black%29.svg/800px-Juventus_FC_2017_icon_%28black%29.svg.png"
            ></img>
          </div>
          <div className={classes.basicInfo}>
            <h2>Juventus FC</h2>
            <p>Country: Italy</p>
            <p>League: Serie A</p>
          </div>
        </div>
      </div>
      <div className={classes.playerMenu}>
        <div className={classes.playerMenuItem} onClick={() => setTab("Stats")}>
          Stats
        </div>
        <div className={classes.playerMenuItem} onClick={() => setTab("Squad")}>
          Squad
        </div>
        <div
          className={classes.playerMenuItem}
          onClick={() => setTab("Matches")}
        >
          Matches
        </div>
      </div>
      <div className={classes.seasonContainer}>
        <div className={classes.seasonSelectContainer}>
          <span>Season:</span>
          <Select
            defaultValue={selectedSeason}
            onChange={setSelectedSeason}
            options={seasons}
            isClearable
            placeholder="Select season"
          />
        </div>
      </div>
      {tab === "Stats" && (
        <div className={classes.whiteContainerInfo}>
          <h3>Statistics</h3>
          <br></br>
          <div className={classes.statistics}></div>
        </div>
      )}
      {tab === "Squad" && <Players></Players>}
      {tab === "Matches" && (
        <div className={classes.whiteContainerInfo}>
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
            <div className={classes.result}>
              <div className={classes.teamsDateContainer}>
                <div>
                  <p>25.08.2023.</p>
                </div>
                <div>
                  <p className={classes.winner}>Tim1</p>
                  <p>Tim1</p>
                </div>
              </div>

              <div className={classes.score}>
                <p>2</p>
                <p>1</p>
              </div>
            </div>
            <div className={classes.result}>
              <div className={classes.teamsDateContainer}>
                <div>
                  <p>25.08.2023.</p>
                </div>
                <div>
                  <p className={classes.winner}>Tim1</p>
                  <p>Tim1</p>
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
    </div>
  );
};
export default Team;
