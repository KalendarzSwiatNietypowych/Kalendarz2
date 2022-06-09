import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { SelectUser } from "../auth/slice";
import { EventsContainer } from "../common/components/containers/EventsContainer";
import { useAppSelector } from "../common/store/rootReducer";
import { useDispatch } from "react-redux";
import { deleteEventAction, getAllEventsAction } from "./eventActions";
import { SelectAllEvents } from "./selectors";
import { Event } from "../common/components/containers/Event";
import event from "../common/models/event/event";
import LocationOnIcon from "@mui/icons-material/LocationOn";
import CircleIcon from "@mui/icons-material/Circle";
import EditIcon from "@mui/icons-material/Edit";
import DeleteForeverIcon from "@mui/icons-material/DeleteForever";
import moment from "moment";
import { CreditScore } from "@mui/icons-material";
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
  const today = new Date();
  const futureEvents = events.filter(
    (e) => new Date(e.endEvent).getTime() > today.getTime()
  );
  const nonDeletedEvents = futureEvents.filter((e) => !e.isDeleted);
  console.log(today.getTime());
  console.log(events);
  console.log(futureEvents);
  console.log(nonDeletedEvents);

  const handleEdit = (event: event) => {
    navigate("/updateEvent", {
      state: {
        id: event.id,
        authorId: event.authorId,
        title: event.title,
        description: event.description,
        location: event.location,
        participantsEmails: event.participantsEmails,
        startEvent: event.startEvent,
        endEvent: event.endEvent,
        color: event.color,
        isDeleted: event.isDeleted,
        isRecurring: event.isRecurring,
      },
    });
  };

  const handleDelete = (event: event) => {
    dispatch(
      deleteEventAction({
        authorId: event.authorId,
        eventId: event.id,
      })
    );
  };

  return (
    <EventsContainer darkmode={false}>
      {isLogged && nonDeletedEvents.length > 0 && <h1>Upcoming Events:</h1>}
      {isLogged && nonDeletedEvents.length == 0 && (
        <h1>You don't have any upcoming events</h1>
      )}
      {!isLogged && (
        <h1>
          <span onClick={() => navigate("/login")}>Sign in</span> to add events
        </h1>
      )}
      {isLogged &&
        nonDeletedEvents.length > 0 &&
        nonDeletedEvents.map((event) => {
          return (
            <Event bcolor={event.color}>
              <div className="eventTitle">
                <h2>{event.title}</h2>
                <CircleIcon />
              </div>
              <h3>{event.description}</h3>
              <h3>{moment(event.startEvent).format("DD-MM-yyyy HH:mm")}</h3>
              <div className="eventLocation">
                <h3>{event.location != "" ? event.location : "No location"}</h3>
                <LocationOnIcon />
              </div>
              <div className="eventButtons">
                <EditIcon onClick={() => handleEdit(event)} />
                <DeleteForeverIcon onClick={() => handleDelete(event)} />
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
