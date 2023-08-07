import React from "react";
import classes from "./styles/Leagues.module.css";
import { useState, useEffect } from "react";

const Leagues = () => {
  const [leagues, setLeagues] = useState<any[]>();

  useEffect(() => {
    fetch("http://localhost:5271/api/leagues", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        setLeagues(data);
      })
      .catch((error) => {
        alert(error);
      });
  }, []);

  return (
    <div>
      <div className={classes.whiteContainer}>
        <h2>Leagues</h2>
        <br></br>
        <div className={classes.leagues}>
          <table className={classes.leaguesTable}>
            <thead>
              <tr>
                <th>Name</th>
              </tr>
            </thead>
            <tbody>
              {leagues?.map((league) => (
                <tr key={league.id}>
                  <td>{league.name}</td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      </div>
    </div>
  );
};

export default Leagues;
