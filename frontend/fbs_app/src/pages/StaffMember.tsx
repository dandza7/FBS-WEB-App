import React from "react";
import classes from "./styles/Player.module.css";
import { useState, useEffect } from "react";
import { useParams } from "react-router";
import dayjs from "dayjs";
import { useNavigate } from "react-router";
import PlayerResultCard from "../components/Results/PlayerResultCard";
import Pagination from "../components/Utils/Pagination";

const StaffMember = () => {
  const [showAwards, setshowAwards] = useState(false);
  const [staffMember, setStaffMember] = useState(null);
  const [employments, setEmployments] = useState<any[]>([]);
  const [awards, setAwards] = useState<any[]>([]);
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
    fetch("http://localhost:5271/api/staff/" + id, {
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
        setStaffMember(data);
        fetchEmployments();
      })
      .catch((error) => {
        alert(error);
      });
  }, []);

  const fetchEmployments = () => {
    fetch("http://localhost:5271/api/staff/" + id + "/employments", {
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
        setEmployments(data);
      })
      .catch((error) => {
        alert(error);
      });
  };

  useEffect(() => {
    fetch("http://localhost:5271/api/staff/" + id + "/awards", {
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
        setAwards(data);
      })
      .catch((error) => {
        alert(error);
      });
  }, []);

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
              src={
                staffMember?.photo
                  ? `data:image/png;base64,${staffMember?.photo}`
                  : "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_960_720.png"
              }
            ></img>
          </div>
          <div className={classes.basicInfo}>
            <h2>{staffMember?.name}</h2>
            <div className={classes.playerCountry}>
              <img
                className={classes.flagImage}
                src={`data:image/png;base64,${staffMember?.countryFlag}`}
              ></img>
              {staffMember?.countryName}
            </div>

            <p>
              Age: {getAge(staffMember?.birthDate)} (
              {dayjs(staffMember?.birthDate).format("DD.MM.YYYY")})
            </p>
          </div>
        </div>
      </div>
      <div className={classes.playerMenu}>
        <div
          className={
            !showAwards
              ? classes.playerMenuItemSelected
              : classes.playerMenuItem
          }
          onClick={() => setshowAwards(false)}
        >
          Career
        </div>
        <div
          className={
            showAwards ? classes.playerMenuItemSelected : classes.playerMenuItem
          }
          onClick={() => setshowAwards(true)}
        >
          Awards
        </div>
      </div>
      {!showAwards && (
        <div className={classes.whiteContainer}>
          {employments?.length > 0 ? (
            <>
              <h3>Carrer</h3>
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
                    {employments?.map((employment: any) => (
                      <tr>
                        <td>
                          <div className={classes.imgNameColumn}>
                            {employment?.teamLogo && (
                              <img
                                className={classes.tableFlag}
                                src={`data:image/png;base64,${employment?.teamLogo}`}
                              ></img>
                            )}
                            <span
                              className={classes.employment_teamName}
                              onClick={() => {
                                navigate("/team/" + employment.teamId);
                              }}
                            >
                              {employment?.teamName}
                            </span>
                          </div>
                        </td>
                        <td>
                          {dayjs(employment.startDate).format("DD.MM.YYYY")}-
                          {dayjs(employment.endDate).format("DD.MM.YYYY")}
                        </td>
                      </tr>
                    ))}
                  </tbody>
                </table>
              </div>
            </>
          ) : (
            <div>There is no data for this person.</div>
          )}
        </div>
      )}
      {showAwards && (
        <div className={classes.whiteContainer}>
          {awards.length > 0 ? (
            <>
              <h3>Awards</h3>
              <br></br>
              <div className={classes.engagaments}>
                <table className={classes.engagamentsTable}>
                  <thead>
                    <tr>
                      <th>Award</th>
                      <th>Season</th>
                      <th>League</th>
                    </tr>
                  </thead>
                  <tbody>
                    {awards?.map((award: any) => (
                      <tr>
                        <td>
                          <div className={classes.imgNameColumn}>
                            {award?.type}
                            {award.month && ` - ${award.month}`}
                          </div>
                        </td>
                        <td>{award.season}</td>
                        <td>{award.league}</td>
                      </tr>
                    ))}
                  </tbody>
                </table>
              </div>
            </>
          ) : (
            <div>There is no data for this person.</div>
          )}
        </div>
      )}
    </div>
  );
};

export default StaffMember;
