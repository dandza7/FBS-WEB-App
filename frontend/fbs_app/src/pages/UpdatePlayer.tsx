import React, { useContext } from "react";
import classes from "./styles/NewPlayer.module.css";
import { LocalizationProvider } from "@mui/x-date-pickers/LocalizationProvider";
import { DatePicker } from "@mui/x-date-pickers";
import Select from "react-select";
import { useState, useEffect } from "react";
import AuthContext from "../store/auth-context";
import dayjs, { Dayjs } from "dayjs";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import { useNavigate } from "react-router";
import { useParams } from "react-router";

const positions = [
  { value: "Goalkeeper", label: "Goalkeeper" },
  { value: "Defender", label: "Defender" },
  { value: "Midfielder", label: "Midfielder" },
  { value: "Attacker", label: "Attacker" },
];

const UpdatePlayer = () => {
  const [photo, setPhoto] = useState([]);
  const [lastName, setLastName] = useState("");
  const [firstName, setFirstName] = useState("");
  const [country, setCountry] = useState("");
  const [position, setPosition] = useState("");
  const [countries, setCountries] = useState<any[]>([]);
  const [selectedCountry, setSelectedCountry] = useState(null);
  const [selectedPosition, setSelectedPosition] = useState(null);
  const navigate = useNavigate();
  const authCtx = useContext(AuthContext);
  const [selectedBirthDate, setSelectedBirthDate] =
    React.useState<Dayjs | null>(dayjs(Date.now()));
  const [player, setPlayer] = useState(null);
  const { id } = useParams();

  useEffect(() => {
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
        const fullName = data.name.split(" ");
        setPlayer(data);
        setFirstName(fullName[0]);
        setLastName(fullName[1]);
        setSelectedPosition({ value: data.position, label: data.position });
        setSelectedCountry({ value: 1, label: data.countryName });
      })
      .catch((error) => {
        alert(error);
      });
  }, []);

  useEffect(() => {
    fetch("http://localhost:5271/api/countries", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        const allCountries: any = [];

        data.map((item: any) => {
          allCountries.push({
            value: item.id,
            label: item.name,
          });
        });
        setCountries(allCountries);
      })
      .catch((error) => {
        alert(error);
      });
  }, []);

  const changeLastNameHandler = (event: any) => {
    setLastName(event.target.value);
  };
  const changeFirstNameHandler = (event: any) => {
    setFirstName(event.target.value);
  };

  const fileSelectedHandler = (element: any) => {
    var file = element.target.files[0];
    var reader = new FileReader();
    reader.onloadend = function () {
      setPhoto([reader.result]);
    };
    reader.readAsDataURL(file);
  };

  const handleChange = (selected) => {
    if (!selected) {
      setSelectedCountry({
        value: "0",
        label: "",
      });
    } else {
      setSelectedCountry(selected);
    }
  };

  const savePlayerHandler = () => {
    fetch("http://localhost:5271/api/players/update", {
      method: "POST",
      body: JSON.stringify({
        id: player.id,
        name: `${firstName} ${lastName}`,
        position: selectedPosition?.value,
        photo: photo[0]?.slice(23),
        birthDate: dayjs(selectedBirthDate).format("YYYY-MM-DD"),
        countryId: selectedCountry?.value,
      }),
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        navigate("/player/" + player.id);
      })
      .catch((error) => {
        alert(error);
      });
  };

  return (
    <div className={classes.whiteContainer}>
      <h2>Update player</h2>
      <br></br>
      <div className={classes.playerForm}>
        <div className={classes.photoContainer}>
          <img
            src={
              photo.length > 0
                ? photo
                : "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_960_720.png"
            }
            className={classes.photo}
          ></img>
          <div className={classes.imageInputContainer}>
            <label htmlFor="files">
              Select Image
              <input
                id="files"
                type="file"
                onChange={fileSelectedHandler}
                className={classes.imageInput}
              ></input>
            </label>
          </div>
        </div>
        <div className={classes.inputFields}>
          <div className={classes.field}>
            <span className={classes.span}>First name: </span>
            <input
              className={classes.nameInput}
              value={firstName}
              onChange={changeFirstNameHandler}
            ></input>
          </div>
          <div className={classes.field}>
            <span className={classes.span}>Last name: </span>
            <input
              className={classes.nameInput}
              value={lastName}
              onChange={changeLastNameHandler}
            ></input>
          </div>
          <div className={classes.field}>
            <span className={classes.span}>Birthdate: </span>
            <LocalizationProvider dateAdapter={AdapterDayjs}>
              <DatePicker
                slotProps={{ textField: { size: "small" } }}
                value={selectedBirthDate}
                onChange={(newValue) => {
                  console.log(newValue);
                  setSelectedBirthDate(newValue);
                }}
              />
            </LocalizationProvider>
          </div>
          {selectedCountry && (
            <div className={classes.field}>
              <span className={classes.span}>Country:</span>
              <Select
                className={classes.select}
                defaultValue={selectedCountry}
                onChange={handleChange}
                options={countries}
                isClearable
                placeholder="Select country..."
              ></Select>
            </div>
          )}
          {selectedPosition && (
            <div className={classes.field}>
              <span className={classes.span}>Position:</span>
              <Select
                className={classes.select}
                defaultValue={selectedPosition}
                onChange={setSelectedPosition}
                options={positions}
                isClearable
              ></Select>
            </div>
          )}
        </div>
        <div className={classes.buttonContainer}>
          <button
            onClick={savePlayerHandler}
            className={classes.savePlayerButton}
          >
            Save
          </button>
        </div>
      </div>
    </div>
  );
};

export default UpdatePlayer;
