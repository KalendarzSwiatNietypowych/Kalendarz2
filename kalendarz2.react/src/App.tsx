import "./App.css";
import { Events } from "./event/Events";
import { ImportantEvents } from "./event/ImportantEventsList";
import { Navbar } from "./navbar/Navbar";
import { Sidebar } from "./navbar/Sidebar";

function App() {
  return (
    <div className="App">
      <Sidebar />
      <Navbar />
      <Events />
    </div>
  );
}

export default App;
