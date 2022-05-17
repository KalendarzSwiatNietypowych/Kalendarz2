import { Link, Route, Routes } from "react-router-dom";
import { Login } from "../auth/login/Loginn";
import { Register } from "../auth/register/Register";
import Calendar from "../calendar/Calendar";
import { Event } from "../event/Event";
import "react-toastify/dist/ReactToastify.css";
import { Home } from "../home/Home";
import { NavbarContainer } from "../common/components/containers/navbarContainer";
import { ToastContainer } from "react-toastify";
import { useAppSelector } from "../common/store/rootReducer";
import { SelectUser } from "../auth/slice";
import { useEffect, useState } from "react";
import LoginIcon from "@mui/icons-material/Login";
import LogoutIcon from "@mui/icons-material/Logout";

export const Navbar = () => {
  let currentUser = useAppSelector((state) => SelectUser(state));
  const [isLogged, setIsLogged] = useState(false);
  useEffect(() => {
    if (localStorage.getItem("userToken") !== null) {
      setIsLogged(true);
    } else {
      setIsLogged(false);
    }
  }, [currentUser.token, localStorage]);

  const handleLogout = () => {
    localStorage.clear();
    window.location.reload();
  };

  return (
    <div>
      <NavbarContainer>
        <ToastContainer autoClose={2000} />
        <p>Calendar</p>
        {!isLogged && (
          <Link to="/login">
            Sign in
            <LoginIcon />
          </Link>
        )}
        {isLogged && (
          <a onClick={handleLogout}>
            Sign out
            <LogoutIcon />
          </a>
        )}
      </NavbarContainer>

      <Routes>
        <Route path="/login" element={<Login />}></Route>
        <Route path="/register" element={<Register />}></Route>
        <Route path="/calendar" element={<Calendar />}></Route>
        <Route path="/" element={<Home />}></Route>
        <Route path="/event" element={<Event />}></Route>
      </Routes>
    </div>
  );
};
