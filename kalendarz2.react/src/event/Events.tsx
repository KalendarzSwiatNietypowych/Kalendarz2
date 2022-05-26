import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { SelectUser } from "../auth/slice";
import { EventsContainer } from "../common/components/containers/EventsContainer";
import { useAppSelector } from "../common/store/rootReducer";
import { useDispatch } from "react-redux";
import { getAllEventsAction } from "./eventActions";
import { SelectAllEvents } from "./selectors";
import { Event } from "../common/components/containers/Event";
import LocationOnIcon from "@mui/icons-material/LocationOn";
import CircleIcon from "@mui/icons-material/Circle";
import moment from "moment";
export const Events = () => {
  const dispatch = useDispatch();
  const navigate = useNavigate();
  let currentUser = useAppSelector((state) => SelectUser(state));
  const [isLogged, setIsLogged] = useState(false);

  useEffect(() => {
    if (currentUser.id != 0) {
      setIsLogged(true);
      dispatch(getAllEventsAction({ authorId: currentUser.id }));
    } else {
      setIsLogged(false);
    }
  }, [currentUser.token, localStorage]);

  // useEffect(() => {
  //   dispatch(getAllEventsAction({ authorId: currentUser.id }));
  // }, []);

  const events = useAppSelector((state) => SelectAllEvents(state));
  const calendar_events = events.map((e) => {
    return {
      title: e.title,
      start: e.startEvent,
    };
  });

  console.log(calendar_events);
  return (
    <EventsContainer>
      {isLogged && events.length > 0 && <h1>Events:</h1>}
      {!isLogged && (
        <h2>
          <span onClick={() => navigate("/login")}>Sign in</span> to be able to
          add events
        </h2>
      )}
      {isLogged &&
        events.length > 0 &&
        events.map((event) => {
          return (
            <Event>
              <div className="eventTitle">
                <h2>{event.title}</h2>
                <CircleIcon />
              </div>
              <h3>{moment(event.startEvent).format("DD-MM-yyyy HH:mm")}</h3>
              <div className="eventLocation">
                <h3>{event.location != "" ? event.location : "No location"}</h3>
                <LocationOnIcon />
              </div>
            </Event>
          );
        })}
      {isLogged && events.length == 0 && (
        <h1>
          <span onClick={() => navigate("/event")}>Add</span>your first event!
        </h1>
      )}
    </EventsContainer>
  );
};
