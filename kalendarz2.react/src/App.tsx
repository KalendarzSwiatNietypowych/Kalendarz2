import { useLocation } from "react-router-dom";
import { createGlobalStyle } from "styled-components";
import { SelectColors, SelectUser } from "./auth/slice";
import { AppContainer } from "./common/components/containers/appContainer";
import { useAppSelector } from "./common/store/rootReducer";
import { Events } from "./event/Events";
import { Navbar } from "./navbar/Navbar";

function App() {
  let currentUser = useAppSelector((state) => SelectUser(state));
  const GlobalStyle = createGlobalStyle`
  body {
    background-color: ${
      currentUser.isDarkmode ? "#3e3e3e !important" : "#AEAEAE !important"
    };
  }
`;
  const location = useLocation();
  const calendarColors = useAppSelector((state) => SelectColors(state));
  return (
    <div>
      <AppContainer
        darkmode={calendarColors.isDarkmode}
        color={calendarColors.color}
      >
        <GlobalStyle />
        <Navbar />
        {location.pathname == "/" && <Events />}
      </AppContainer>
    </div>
  );
}

export default App;
