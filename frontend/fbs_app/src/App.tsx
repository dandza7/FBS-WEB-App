import { useState } from "react";
import AuthContext from "./store/auth-context";
import "./App.css";
import {
  createBrowserRouter,
  RouterProvider,
  Route,
  Link,
  createRoutesFromElements,
} from "react-router-dom";
import RootLayout from "./components/RootLayout.tsx/RootLayout";
import Login from "./pages/Login";
import Leagues from "./pages/Leagues";
import League from "./pages/League";
import Teams from "./pages/Teams";
import Players from "./pages/Players";
import Player from "./pages/Player";
import Team from "./pages/Team";
import Staff from "./pages/Staff";
import { Match } from "./pages/Match";
import StaffMember from "./pages/StaffMember";

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route>
      <Route path="/login" element={<Login></Login>} />
      <Route path="/" element={<RootLayout></RootLayout>}>
        {<Route path="/" index element={<></>}></Route>}
        <Route path="/leagues" element={<Leagues></Leagues>}></Route>
        <Route path="/league/:id" element={<League></League>}></Route>
        <Route path="/teams" element={<Teams></Teams>}></Route>
        <Route path="/staff" element={<Staff></Staff>}></Route>
        <Route path="/players" element={<Players></Players>}></Route>
        <Route path="/player/:id" element={<Player></Player>}></Route>
        <Route path="/team/:id" element={<Team></Team>}></Route>
        <Route path="/match/:id" element={<Match></Match>}></Route>
        <Route path="/staff/:id" element={<StaffMember></StaffMember>}></Route>
      </Route>
    </Route>
  )
);

function App() {
  return (
    <>
      <RouterProvider router={router}></RouterProvider>
    </>
  );
}

export default App;
