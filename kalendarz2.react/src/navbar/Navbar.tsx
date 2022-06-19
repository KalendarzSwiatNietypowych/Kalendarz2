import { Link, Route, Routes, useNavigate } from "react-router-dom";
import { Login } from "../auth/login/Loginn";
import { Register } from "../auth/register/Register";
import { Calendar } from "../calendar/Calendar";
import { AddEvent } from "../event/AddEvent";
import "react-toastify/dist/ReactToastify.css";
import { NavbarContainer } from "../common/components/containers/navbarContainer";
import { ToastContainer } from "react-toastify";
import { useAppSelector } from "../common/store/rootReducer";
import { loadLocalStorage, SelectUser } from "../auth/slice";
import { useEffect, useState } from "react";
import LoginIcon from "@mui/icons-material/Login";
import LogoutIcon from "@mui/icons-material/Logout";
import CalendarMonthIcon from "@mui/icons-material/CalendarMonth";
import AddIcon from "@mui/icons-material/Add";
import NotificationsIcon from "@mui/icons-material/Notifications";
import NotificationImportantIcon from "@mui/icons-material/NotificationImportant";
import SettingsIcon from "@mui/icons-material/Settings";
import { useDispatch } from "react-redux";
import { store } from "..";
import { UpdateEvent } from "../event/UpdateEvent";
import { Settings } from "../settings/Settings";
import { ChangePassword } from "../auth/changePassword/ChangePassword";
import { Notifications } from "../event/Notifications";
import logo from "../common/components/img/logo.png";
export const Navbar = () => {
  const dispatch = useDispatch();
  useEffect(() => {
    store.dispatch(loadLocalStorage());
  }, []);
  let eventInAnHour = 0;
  const navigate = useNavigate();
  let currentUser = useAppSelector((state) => SelectUser(state));
  const events = useAppSelector((state) => state.event.events);
  events.map((e) => {
    if (
      new Date(e.startEvent).getTime() - new Date().getTime() > 0 &&
      new Date(e.startEvent).getTime() - new Date().getTime() < 60 * 60 * 1000
    ) {
      eventInAnHour = eventInAnHour + 1;
    }
  });
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
    navigate("/");
    window.location.reload();
  };

  return (
    <div>
      <NavbarContainer
        darkmode={currentUser.isDarkmode}
        color={currentUser.color}
      >
        <ToastContainer autoClose={2000} position="top-left" />

        <p onClick={() => navigate("/")}>
          <img src={logo} />
          Calendar
        </p>
        <CalendarMonthIcon onClick={() => navigate("/")} />
        {isLogged && <AddIcon onClick={() => navigate("/event")} />}
        {isLogged && eventInAnHour == 0 && (
          <NotificationsIcon onClick={() => navigate("/notifications")} />
        )}
        {isLogged && eventInAnHour > 0 && (
          <NotificationImportantIcon
            onClick={() => navigate("/notifications")}
          />
        )}
        {isLogged && <SettingsIcon onClick={() => navigate("/settings")} />}
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
        <Route path="/" element={<Calendar />}></Route>
        <Route path="/changePassword" element={<ChangePassword />}></Route>
        <Route path="/notifications" element={<Notifications />}></Route>
        <Route path="/event" element={<AddEvent />}></Route>
        <Route path="/settings" element={<Settings />}></Route>
        <Route path="/updateEvent" element={<UpdateEvent />}></Route>
        <Route path="*" element={<Calendar />} />
      </Routes>
    </div>
  );
};
