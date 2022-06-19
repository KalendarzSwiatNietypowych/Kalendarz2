import { useEffect } from "react";
import { SelectUser } from "../auth/slice";
import { useAppSelector } from "../common/store/rootReducer";
import { useDispatch } from "react-redux";
import { getAllEventsAction } from "./eventActions";
import { SelectAllEvents } from "./selectors";
import { NotificationsContainer } from "../common/components/containers/notificationsContainer";
import { Notification } from "./Notification";
export const Notifications = () => {
  const dispatch = useDispatch();
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
  }, []);

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
  const recurringEvents = events.map((e) => {
    if (e.isRecurring) {
      console.log(e);
      const nextStartYear = new Date(e.startEvent).getFullYear();
      const nextEndYear = new Date(e.endEvent).getFullYear();
      const newStartDate = new Date(e.startEvent);
      const newEndDate = new Date(e.endEvent);
      newStartDate.setFullYear(nextStartYear + 1);
      newEndDate.setFullYear(nextEndYear + 1);
      if (
        newStartDate.getDate() == today.getDate() &&
        newStartDate.getMonth() == today.getMonth() &&
        newStartDate.getFullYear() == today.getFullYear() &&
        !isBeforeNow(newStartDate)
      ) {
        todaysEvents.push({
          id: e.id,
          authorId: e.authorId,
          title: e.title,
          description: e.description,
          location: e.location,
          participantsEmails: e.participantsEmails,
          startEvent: newStartDate,
          endEvent: newEndDate,
          color: e.color,
          isDeleted: e.isDeleted,
          isRecurring: false,
          isEditable: false,
        });
      } else if (
        newStartDate.getDate() == today.getDate() + 1 &&
        newStartDate.getMonth() == today.getMonth() &&
        newStartDate.getFullYear() == today.getFullYear()
      ) {
        tomorrowsEvents.push({
          id: e.id,
          authorId: e.authorId,
          title: e.title,
          description: e.description,
          location: e.location,
          participantsEmails: e.participantsEmails,
          startEvent: newStartDate,
          endEvent: newEndDate,
          color: e.color,
          isDeleted: e.isDeleted,
          isRecurring: false,
          isEditable: false,
        });
      }
    }
  });
  const filteredTodaysEvents = todaysEvents.filter((e) => !e.isDeleted);
  const filteredTomorrowsEvents = tomorrowsEvents.filter((e) => !e.isDeleted);

  const sortedtodaysEvents = filteredTodaysEvents.sort(function (a, b) {
    return new Date(a.endEvent).getTime() - new Date(b.endEvent).getTime();
  });

  const sortedtomorrowsEvents = filteredTomorrowsEvents.sort(function (a, b) {
    return new Date(a.endEvent).getTime() - new Date(b.endEvent).getTime();
  });

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
                event={event}
                today={true}
              ></Notification>
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
                event={event}
                today={false}
              ></Notification>
            );
          })}
        </div>
      </div>
    </NotificationsContainer>
  );
};
