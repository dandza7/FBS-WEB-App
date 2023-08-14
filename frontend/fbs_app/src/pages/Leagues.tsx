import React from "react";
import classes from "./styles/Leagues.module.css";
import { useState, useEffect } from "react";
import ReactLoading from "react-loading";
import { useNavigate } from "react-router";

const Leagues = () => {
  const [leagues, setLeagues] = useState<any[]>();
  const [isLoading, setIsLoading] = useState(false);
  const navigate = useNavigate();

  useEffect(() => {
    setIsLoading(true);
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
        setIsLoading(false);
      })
      .catch((error) => {
        alert(error);
      });
  }, []);

  const viewLeagueHandler = (id: number) => {
    navigate("/league/" + id);
  };

  return (
    <div>
      <div className={classes.whiteContainer}>
        <h2>Leagues</h2>
        <br></br>
        {isLoading ? (
          <div className={classes.loadingContainer}>
            <ReactLoading
              type={"spin"}
              color={"#1f2466"}
              height={30}
              width={30}
            />
          </div>
        ) : (
          <div className={classes.leagues}>
            <table className={classes.leaguesTable}>
              <thead>
                <tr>
                  <th>Name</th>
                </tr>
              </thead>
              <tbody>
                {leagues?.map((league) => (
                  <tr
                    key={league.id}
                    onClick={() => {
                      viewLeagueHandler(league.id);
                    }}
                  >
                    <td>
                      <div className={classes.league}>
                        <img
                          src={`data:image/png;base64,${league?.flag}`}
                          className={classes.flag}
                        ></img>
                        <span>{league.name}</span>
                      </div>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        )}
      </div>
    </div>
  );
};

export default Leagues;
