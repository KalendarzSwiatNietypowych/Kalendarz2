import { useLocation } from "react-router-dom";
import "./App.css";
import { SelectColors } from "./auth/slice";
import { AppContainer } from "./common/components/containers/appContainer";
import { useAppSelector } from "./common/store/rootReducer";
import { Events } from "./event/Events";
import { Navbar } from "./navbar/Navbar";

function App() {
  const location = useLocation();
  const calendarColors = useAppSelector((state) => SelectColors(state));
  return (
    <div>
      <AppContainer
        darkmode={calendarColors.isDarkmode}
        color={calendarColors.color}
      >
        <Navbar />
        {location.pathname == "/" && <Events />}
      </AppContainer>
    </div>
  );
}

export default App;
