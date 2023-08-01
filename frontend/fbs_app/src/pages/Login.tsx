import React from "react";
import { Link } from "react-router-dom";
import {
  Container,
  Button,
  Grid,
  Paper,
  TextField,
  IconButton,
  InputAdornment,
} from "@mui/material";
import VisibilityIcon from "@mui/icons-material/Visibility";
import VisibilityOffIcon from "@mui/icons-material/VisibilityOff";
import { useState, useContext } from "react";
import { useNavigate } from "react-router-dom";
import classes from "./styles/Login.module.css";

const Login = () => {
  const [values, setValues] = useState({
    email: "",
    pass: "",
  });

  const [showPass, setShowPass] = useState(false);
  const handleChange = (e: any) => {
    setValues({
      ...values,
      [e.target.name]: e.target.value,
    });
  };

  const togglePasswordHide = () => {
    setShowPass((prevState) => !prevState);
  };

  return (
    <div className={classes.login}>
      <div className={classes.loginFormContainer}>
        <div>
          <Container maxWidth="sm">
            <Grid
              container
              spacing={2}
              direction="column"
              justifyContent="center"
              style={{ minHeight: "100vh" }}
            >
              <>
                <form className={classes.loginForm}>
                  <Grid container direction="column" spacing={2}>
                    <Grid item alignSelf={"center"} marginBottom={5}>
                      <p className={classes.title}>Sign in</p>
                    </Grid>
                    <Grid item>
                      <TextField
                        name="email"
                        type="email"
                        fullWidth
                        label="Enter your email"
                        placeholder="Email Address"
                        variant="outlined"
                        required
                        onChange={handleChange}
                      />
                    </Grid>

                    <Grid item>
                      <TextField
                        name="pass"
                        type={showPass ? "text" : "password"}
                        fullWidth
                        label="Password"
                        placeholder="Password"
                        variant="outlined"
                        required
                        InputProps={{
                          endAdornment: (
                            <InputAdornment position="end">
                              <IconButton
                                aria-label="toggle password"
                                edge="end"
                                onClick={togglePasswordHide}
                              >
                                {showPass ? (
                                  <VisibilityIcon />
                                ) : (
                                  <VisibilityOffIcon />
                                )}
                              </IconButton>
                            </InputAdornment>
                          ),
                        }}
                      />
                    </Grid>
                    <Grid item>
                      <p>
                        Not a member?{" "}
                        <Link to={"/register"}>Register here!</Link>
                      </p>
                    </Grid>
                    <Grid item>
                      <Button
                        className={classes.loginButton}
                        type="submit"
                        fullWidth
                        variant="contained"
                      >
                        Sign In
                      </Button>
                    </Grid>
                  </Grid>
                </form>
              </>
            </Grid>
          </Container>
        </div>
      </div>
    </div>
  );
};

export default Login;
