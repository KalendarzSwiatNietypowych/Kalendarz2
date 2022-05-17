import { useEffect, useState } from "react";
import "./App.css";
import { SelectUser } from "./auth/slice";
import { useAppSelector } from "./common/store/rootReducer";
import { Events } from "./event/Events";
import { Navbar } from "./navbar/Navbar";
import { Sidebar } from "./navbar/Sidebar";

function App() {
  let currentUser = useAppSelector((state) => SelectUser(state));
  const [isLogged, setIsLogged] = useState(false);
  useEffect(() => {
    if (localStorage.getItem("userToken") !== null) {
      setIsLogged(true);
    } else {
      setIsLogged(false);
    }
  }, [currentUser.token, localStorage]);

  return (
    <div className="App">
      <Sidebar displayIcons={isLogged} />
      <Navbar />
      {isLogged && <Events />}
    </div>
  );
}

export default App;
