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
import { BasicInput } from "../common/components/inputs/basicInput";
export const Events = () => {
  const dispatch = useDispatch();
  const navigate = useNavigate();
  let currentUser = useAppSelector((state) => SelectUser(state));
  const [isLogged, setIsLogged] = useState(false);
  const [isUpcoming, setIsUpcoming] = useState(true);
  const [query, setQuery] = useState("");

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

  const calculateColor = (backgroundColor: string) => {
    var result = /^#?([a-f\d]{2})([a-f\d]{2})([a-f\d]{2})$/i.exec(
      backgroundColor
    );
    if (result === null) {
      return "black";
    }
    var r = parseInt(result![1], 16);
    var g = parseInt(result![2], 16);
    var b = parseInt(result![3], 16);

    var luminance = (0.299 * r + 0.587 * g + 0.114 * b) / 255;

    if (luminance > 0.5) {
      return "black";
    } else {
      return "white";
    }
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
          <BasicInput
            name="search"
            placeholder="Search events"
            value={query}
            onChange={(event) => setQuery(event.target.value)}
          />
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
        eventsToDisplay
          .filter((post) => {
            if (query === "") {
              return post;
            } else if (post.title.toLowerCase().includes(query.toLowerCase())) {
              return post;
            }
          })
          .map((event) => {
            return (
              <Event
                bcolor={event.color}
                textColor={calculateColor(event.color)}
              >
                <div className="eventTitle">
                  <h2>{event.title}</h2>
                  <EventIcon />
                </div>
                <h3>{event.description}</h3>
                <h3>
                  Starts: {moment(event.startEvent).format("DD-MM-yyyy HH:mm")}
                </h3>
                <h3>
                  Ends: {moment(event.endEvent).format("DD-MM-yyyy HH:mm")}
                </h3>
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
