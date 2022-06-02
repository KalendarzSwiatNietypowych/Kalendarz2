import { useLocation } from "react-router-dom";
import "./App.css";
import { AppContainer } from "./common/components/containers/appContainer";
import { Events } from "./event/Events";
import { Navbar } from "./navbar/Navbar";

function App() {
  const location = useLocation();
  return (
    <div>
      <AppContainer darkmode={false}>
        <Navbar />
        {location.pathname == "/" && <Events />}
      </AppContainer>
    </div>
  );
}

export default App;
