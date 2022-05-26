import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { SelectUser } from "../auth/slice";
import { EventsContainer } from "../common/components/containers/EventsContainer";
import { useAppSelector } from "../common/store/rootReducer";
import {EventsContainerMainText} from "../common/components/containers/EventsContainerMainText";
import AddLocationAltRoundedIcon from '@mui/icons-material/AddLocationAltRounded';
const dates=["Kolokwium zaliczeniowe", "Egzamin pisemny", "Egzamin ustny", "Mecz piłki nożnej", "xddd", "sdsdsds", "dffff"]
const dateslist=dates.map(date=><EventsContainer><h5>{date}</h5><h6>12:00 - 14:00</h6><h6>Politechnika Rzeszowska</h6><div className="icon">
<AddLocationAltRoundedIcon />
</div></EventsContainer>)

export const Events = () => {
  const navigate = useNavigate();
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
    <EventsContainer>
      {isLogged && <h2>Here are your events:</h2>}
      {!isLogged && (
        <h2>
          <span onClick={() => navigate("/login")}>Sign in</span> to be able to
          add events
        </h2>
      )}
      {isLogged && (
    <EventsContainerMainText>
      <h3>Wydarzenia:</h3>
      {dateslist}
    </EventsContainerMainText>
      )}
    </EventsContainer>

  );
};
