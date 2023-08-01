import React from "react";
import classes from "./Navbar.module.css";
import PersonIcon from "@mui/icons-material/Person";
import MenuIcon from "@mui/icons-material/Menu";
import { useState } from "react";
import { NavLink } from "react-router-dom";
import { useNavigate } from "react-router-dom";
const Navbar = () => {
  const [openMenu, setOpenMenu] = useState(false);
  const navigate = useNavigate();
  const openMenuHandler = () => {
    setOpenMenu(!openMenu);
  };

  const openPageHandler = (url: string) => {
    setOpenMenu(false);
    navigate(url);
  };

  return (
    <>
      <div className={classes.nav}>
        <div className={classes.navbar}>
          <div>
            <div className={classes.navbarItemMenu} onClick={openMenuHandler}>
              <MenuIcon></MenuIcon>
            </div>
            <div className={classes.menuClosed}>
              <div className={classes.navbarItem}>
                <NavLink to="/leagues" className={classes.NavLink}>
                  Leagues
                </NavLink>
              </div>
              <div className={classes.navbarItem}>
                <NavLink to="/teams" className={classes.NavLink}>
                  Teams
                </NavLink>
              </div>
              <div className={classes.navbarItem}>
                <NavLink to="/players" className={classes.NavLink}>
                  Players
                </NavLink>
              </div>
            </div>
          </div>
          <div>
            <div className={classes.navbarItem}>
              <PersonIcon className={classes.icon}></PersonIcon>
            </div>
          </div>
        </div>
      </div>
      {openMenu && (
        <div className={classes.openedMenu}>
          <div className={classes.closeMenuButtonContainer}>
            <button
              className={classes.closeMenuButton}
              onClick={() => {
                setOpenMenu((prevState) => {
                  return !prevState;
                });
              }}
            >
              X
            </button>
          </div>
          <div className={classes.openedMenuItems}>
            <div
              className={classes.openMenuItem}
              onClick={() => openPageHandler("/leagues")}
            >
              <div className={classes.NavLink}>Leagues</div>
            </div>
            <div
              className={classes.openMenuItem}
              onClick={() => openPageHandler("/teams")}
            >
              <div className={classes.NavLink}>Teams</div>
            </div>
            <div
              className={classes.openMenuItem}
              onClick={() => openPageHandler("/players")}
            >
              <div className={classes.NavLink}>Players</div>
            </div>
          </div>
        </div>
      )}
    </>
  );
};

export default Navbar;
