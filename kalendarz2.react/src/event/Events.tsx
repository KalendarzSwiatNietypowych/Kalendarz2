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
import EventIcon from "@mui/icons-material/Event";
import EditIcon from "@mui/icons-material/Edit";
import DeleteForeverIcon from "@mui/icons-material/DeleteForever";
import moment from "moment";
export const Events = () => {
  const dispatch = useDispatch();
  const navigate = useNavigate();
  let currentUser = useAppSelector((state) => SelectUser(state));
  const [isLogged, setIsLogged] = useState(false);
  const [isUpcoming, setIsUpcoming] = useState(true);

  useEffect(() => {
    if (currentUser.id != 0) {
      setIsLogged(true);
      dispatch(getAllEventsAction({ authorId: currentUser.id }));
    } else {
      setIsLogged(false);
    }
  }, [currentUser.token, localStorage]);

  const events = useAppSelector((state) => SelectAllEvents(state));
  const today = new Date();
  const futureEvents = events.filter(
    (e) => new Date(e.endEvent).getTime() > today.getTime()
  );
  const pastEvents = events.filter(
    (e) => new Date(e.endEvent).getTime() <= today.getTime()
  );
  const filteredFutureEvents = futureEvents.filter((e) => !e.isDeleted);
  const sortedFutureEvents = filteredFutureEvents.sort(function (a, b) {
    return new Date(a.endEvent).getTime() - new Date(b.endEvent).getTime();
  });
  const filteredPastEvents = pastEvents.filter((e) => !e.isDeleted);
  const sortedPastEvents = filteredPastEvents.sort(function (a, b) {
    return new Date(a.endEvent).getTime() - new Date(b.endEvent).getTime();
  });
  const eventsToDisplay =
    isUpcoming == true ? sortedFutureEvents : sortedPastEvents;
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
    <EventsContainer
      darkmode={currentUser.isDarkmode}
      color={currentUser.color}
    >
      {isLogged && (
        <>
          <h1>{isUpcoming == true ? "Upcoming" : "Past"} Events:</h1>
          <h4>
            Show{" "}
            <span onClick={() => setIsUpcoming((prevValue) => !prevValue)}>
              {isUpcoming == false ? "upcoming" : "past"} events
            </span>
          </h4>
        </>
      )}
      {isLogged && eventsToDisplay.length == 0 && (
        <h2>
          You don't have any {isUpcoming == true ? "upcoming" : "past"} events{" "}
        </h2>
      )}
      {!isLogged && (
        <h1>
          <span onClick={() => navigate("/login")}>Sign in</span> to add events
        </h1>
      )}
      {isLogged &&
        eventsToDisplay.map((event) => {
          return (
            // <Event bcolor={event.color}>
            //   <div className="eventTitle">
            //     <h2>{event.title}</h2>
            //     <CircleIcon />
            //   </div>
            //   <h3>{event.description}</h3>
            //   <h3>{moment(event.startEvent).format("DD-MM-yyyy HH:mm")}</h3>
            //   <div className="eventLocation">
            //     <h3>{event.location != "" ? event.location : "No location"}</h3>
            //     <LocationOnIcon />
            //   </div>
            //   <div className="eventButtons">
            //     <EditIcon onClick={() => handleEdit(event)} />
            //     <DeleteForeverIcon onClick={() => handleDelete(event)} />
            //   </div>
            // </Event>
            <Event bcolor={event.color}>
              <div className="eventTitle">
                <h2>{event.title}</h2>
                <EventIcon />
              </div>
              <h3>{event.description}</h3>
              <h3>
                Starts: {moment(event.startEvent).format("DD-MM-yyyy HH:mm")}
              </h3>
              <h3>Ends: {moment(event.endEvent).format("DD-MM-yyyy HH:mm")}</h3>
              <div className="eventLocation">
                <h3>
                  {event.location != "" ? event.location : "No location"}
                  <LocationOnIcon />
                </h3>
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
