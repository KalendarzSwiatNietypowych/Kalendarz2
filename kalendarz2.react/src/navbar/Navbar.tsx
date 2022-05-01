import { Link, Route, Routes } from "react-router-dom";
import { Login } from "../auth/login/Loginn";
import { Register } from "../auth/register/Register";
import Calendar from "../calendar/Calendar";
import { Home } from "../home/Home";
import { NavbarContainer } from "../common/components/navbarContainer";
export const Navbar = () => {
  return (
    <div>
      <NavbarContainer>
        <p>Calendar 2: 137</p>
        <Link to="/">Home</Link>
        <Link to="/login">Login</Link>
        <Link to="/register">Register</Link>
        <Link to="/calendar">Calendar</Link>
      </NavbarContainer>
      <br />
      <br />
      <Routes>
        <Route path="/login" element={<Login />}></Route>
        <Route path="/register" element={<Register />}></Route>
        <Route path="/calendar" element={<Calendar />}></Route>
        <Route path="/" element={<Home />}></Route>
      </Routes>
    </div>
  );
};
