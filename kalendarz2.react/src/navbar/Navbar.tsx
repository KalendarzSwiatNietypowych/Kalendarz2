import { Link, Route, Routes } from "react-router-dom";
import { Login } from "../auth/login/Loginn";
import { Register } from "../auth/register/Register";
import Calendar from "../calendar/Calendar";
import "react-toastify/dist/ReactToastify.css";
import { Home } from "../home/Home";
import { NavbarContainer } from "../common/components/containers/navbarContainer";
import { ToastContainer } from "react-toastify";
export const Navbar = () => {
  return (
    <div>
      <NavbarContainer>
        <ToastContainer autoClose={2000} />
        <p>Calendar 2: 137</p>
        <Link to="/">Events</Link>
        <Link to="/calendar">Calendar</Link>
        <Link to="/login">Login</Link>
      </NavbarContainer>
      <Routes>
        <Route path="/login" element={<Login />}></Route>
        <Route path="/register" element={<Register />}></Route>
        <Route path="/calendar" element={<Calendar />}></Route>
        <Route path="/" element={<Home />}></Route>
      </Routes>
    </div>
  );
};
