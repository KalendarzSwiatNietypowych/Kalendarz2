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
export const Navbar = () => {
  const currentUser = useAppSelector((state) => SelectUser(state));
  const [isLogged, setIsLogged] = useState(false);
  useEffect(() => {
    console.log(currentUser.token);
    if (localStorage.getItem("userToken") !== null) {
      setIsLogged(true);
    } else {
      setIsLogged(false);
    }
  }, [currentUser.token, localStorage]);

  return (
    <div>
      <NavbarContainer>
        <ToastContainer autoClose={2000} />
        <p>Calendar 2: 137</p>
        <Link to="/">Events</Link>
        <Link to="/calendar">Calendar</Link>
        {!isLogged && <Link to="/login">Login</Link>}
        {isLogged && <h4>Logout</h4>}
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
