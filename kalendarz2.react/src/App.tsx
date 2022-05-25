import { useLocation } from "react-router-dom";
import "./App.css";
import { Events } from "./event/Events";
import { Navbar } from "./navbar/Navbar";

function App() {
  const location = useLocation();
  return (
    <div className="App">
      <Navbar />
      {location.pathname == "/calendar" && <Events />}
    </div>
  );
}

export default App;
