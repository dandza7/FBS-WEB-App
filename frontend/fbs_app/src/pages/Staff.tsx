import React from "react";
import classes from "./styles/Players.module.css";
import { useState, useEffect } from "react";
import Pagination from "../components/Utils/Pagination";
import PlayerCard from "../components/Players/PlayerCard";
import ReactLoading from "react-loading";
const Staff = () => {
  const pageSize = 10;
  const [staff, setStaff] = useState<any[]>([]);
  const [totalCount, setTotalCount] = useState(null);
  const [selectedPage, setSelectedPage] = useState(1);
  const [isLoading, setIsLoading] = useState(false);

  useEffect(() => {
    setIsLoading(true);
    fetch("http://localhost:5271/api/staff/" + selectedPage + "/" + pageSize, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        setTotalCount(data.totalCount);
        setStaff(data.entities);
        setIsLoading(false);
      })
      .catch((error) => {
        alert(error);
      });
  }, [selectedPage]);

  const changePage = (page: number) => {
    setSelectedPage(page);
    window.scrollTo({ top: 0, left: 0 });
  };

  return (
    <div>
      <div className={classes.whiteContainer}>
        <div className={classes.titleFiltersContainer}>
          <h2>Staff</h2>
        </div>
        {isLoading ? (
          <div className={classes.loadingContainer}>
            <ReactLoading
              type={"spin"}
              color={"#1f2466"}
              height={30}
              width={30}
            />
          </div>
        ) : staff?.length > 0 ? (
          <>
            <div className={classes.players}>
              {staff?.map((staff) => (
                <PlayerCard player={staff} key={staff.id}></PlayerCard>
              ))}
            </div>
            <Pagination
              change={changePage}
              totalCount={totalCount}
              pageSize={pageSize}
              currentPage={selectedPage}
            ></Pagination>
          </>
        ) : (
          <div>No results.</div>
        )}
      </div>
    </div>
  );
};

export default Staff;
