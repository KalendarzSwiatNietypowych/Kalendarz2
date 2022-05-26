import { Link, Route, Routes, useNavigate } from "react-router-dom";
import { Login } from "../auth/login/Loginn";
import { Register } from "../auth/register/Register";
import { Calendar } from "../calendar/Calendar";
import { AddEvent } from "../event/AddEvent";
import "react-toastify/dist/ReactToastify.css";
import { Home } from "../home/Home";
import { NavbarContainer } from "../common/components/containers/navbarContainer";
import { ToastContainer } from "react-toastify";
import { useAppSelector } from "../common/store/rootReducer";
import { loadLocalStorage, SelectUser } from "../auth/slice";
import { useEffect, useState } from "react";
import LoginIcon from "@mui/icons-material/Login";
import LogoutIcon from "@mui/icons-material/Logout";
import CalendarMonthIcon from "@mui/icons-material/CalendarMonth";
import AddIcon from "@mui/icons-material/Add";
import NotificationAddIcon from "@mui/icons-material/NotificationAdd";
import FormatListBulletedIcon from "@mui/icons-material/FormatListBulleted";
import SettingsIcon from "@mui/icons-material/Settings";
import { useDispatch } from "react-redux";
import { store } from "..";

export const Navbar = () => {
  const dispatch = useDispatch();
  useEffect(() => {
    store.dispatch(loadLocalStorage());
  }, []);

  const navigate = useNavigate();
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
    navigate("/calendar");
    window.location.reload();
  };

  return (
    <div>
      <NavbarContainer>
        <ToastContainer autoClose={2000} />
        <p>Calendar</p>
        <CalendarMonthIcon onClick={() => navigate("/calendar")} />
        {isLogged && <AddIcon onClick={() => navigate("/event")} />}
        {isLogged && <NotificationAddIcon />}
        {isLogged && <FormatListBulletedIcon />}
        {isLogged && <SettingsIcon />}
        {!isLogged && (
          <Link to="/login">
            <LoginIcon />
            <span>Sign in</span>
          </Link>
        )}
        {isLogged && (
          <a onClick={handleLogout}>
            <LogoutIcon />
            <span>Sign out</span>
          </a>
        )}
      </NavbarContainer>

      <Routes>
        <Route path="/login" element={<Login />}></Route>
        <Route path="/register" element={<Register />}></Route>
        <Route path="/calendar" element={<Calendar />}></Route>
        <Route path="/" element={<Home />}></Route>
        <Route path="/event" element={<AddEvent />}></Route>
        <Route path="*" element={<Calendar />} />
      </Routes>
    </div>
  );
};
