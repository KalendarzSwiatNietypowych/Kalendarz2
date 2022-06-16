import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { SelectUser } from "../auth/slice";
import { EventsContainer } from "../common/components/containers/EventsContainer";
import { useAppSelector } from "../common/store/rootReducer";
import { useDispatch } from "react-redux";
import { deleteEventAction, getAllEventsAction } from "./eventActions";
import { SelectAllEvents } from "./selectors";
import EventIcon from "@mui/icons-material/Event";
import moment from "moment";
import { NotificationsContainer } from "../common/components/containers/notificationsContainer";
import { Notification } from "../common/components/containers/Notification";

export const Notifications = () => {
  const dispatch = useDispatch();
  const navigate = useNavigate();
  let currentUser = useAppSelector((state) => SelectUser(state));

  const isBeforeNow = (date: Date) => {
    var now = new Date().getTime();
    var distance = new Date(date).getTime() - now;
    if (distance < 0) return true;
    return false;
  };

  useEffect(() => {
    if (currentUser.id != 0) {
      dispatch(getAllEventsAction({ authorId: currentUser.id }));
    } else {
    }
  }, [currentUser.token, localStorage]);

  const events = useAppSelector((state) => SelectAllEvents(state));
  const today = new Date();
  const todaysEvents = events.filter(
    (e) =>
      new Date(e.startEvent).getDate() == today.getDate() &&
      new Date(e.startEvent).getMonth() == today.getMonth() &&
      new Date(e.startEvent).getFullYear() == today.getFullYear() &&
      !isBeforeNow(e.startEvent)
  );
  const tomorrowsEvents = events.filter(
    (e) =>
      new Date(e.startEvent).getDate() == today.getDate() + 1 &&
      new Date(e.startEvent).getMonth() == today.getMonth() &&
      new Date(e.startEvent).getFullYear() == today.getFullYear()
  );

  const sortedtodaysEvents = todaysEvents.sort(function (a, b) {
    return new Date(a.endEvent).getTime() - new Date(b.endEvent).getTime();
  });

  const sortedtomorrowsEvents = tomorrowsEvents.sort(function (a, b) {
    return new Date(a.endEvent).getTime() - new Date(b.endEvent).getTime();
  });

  const calculateColor = (backgroundColor: string) => {
    if (backgroundColor != null) {
      var result = /^#?([a-f\d]{2})([a-f\d]{2})([a-f\d]{2})$/i.exec(
        backgroundColor
      );
      if (result![1] == null) return "black";
      var r = parseInt(result![1], 16);
      var g = parseInt(result![2], 16);
      var b = parseInt(result![3], 16);
      var luminance = (0.299 * r + 0.587 * g + 0.114 * b) / 255;

      if (luminance > 0.5) {
        return "black";
      } else {
        return "white";
      }
    }
  };

  const handleDate = (startEvent: Date) => {
    var now = new Date().getTime();

    var distance = new Date(startEvent).getTime() - now;

    var hours = Math.floor(
      (distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60)
    );
    var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
    var seconds = Math.floor((distance % (1000 * 60)) / 1000);
    if (hours == 0) {
      if (minutes == 0) {
        return <h3 className="bold">Starts in:{seconds}s</h3>;
      }
      return (
        <h3 className="bold">
          Starts in: {minutes}m {seconds}s
        </h3>
      );
    }
    return (
      <h3>
        Starts in: {hours}h {minutes}m {seconds}s
      </h3>
    );
  };
  return (
    <NotificationsContainer
      darkmode={currentUser.isDarkmode}
      color={currentUser.color}
    >
      <div className="notifications-group">
        {sortedtodaysEvents.length > 0 ? (
          <h1>Today's events</h1>
        ) : (
          <h1>You don't have any events today</h1>
        )}

        <div className="notifications">
          {sortedtodaysEvents.map((event) => {
            return (
              <Notification
                bcolor={event.color}
                textColor={calculateColor(event.color)!}
              >
                <div className="eventTitle">
                  <h2>{event.title}</h2>
                  <EventIcon />
                </div>
                <h3>{event.description}</h3>
                {handleDate(event.startEvent)}

                <h3>
                  Ends: {moment(event.endEvent).format("DD-MM-yyyy HH:mm")}
                </h3>
              </Notification>
            );
          })}
        </div>
      </div>
      <div className="notifications-group">
        {sortedtomorrowsEvents.length > 0 ? (
          <h1>Tomorrow's events</h1>
        ) : (
          <h1>You don't have any events tomorrow</h1>
        )}
        <div className="notifications">
          {sortedtomorrowsEvents.map((event) => {
            return (
              <Notification
                bcolor={event.color}
                textColor={calculateColor(event.color)!}
              >
                <div className="eventTitle">
                  <h2>{event.title}</h2>
                  <EventIcon />
                </div>
                <h3>{event.description}</h3>
                <h3>Starts: {moment(event.startEvent).format("HH:mm")}</h3>
                <h3>
                  Ends: {moment(event.endEvent).format("DD-MM-yyyy HH:mm")}
                </h3>
              </Notification>
            );
          })}
        </div>
      </div>
    </NotificationsContainer>
  );
};
