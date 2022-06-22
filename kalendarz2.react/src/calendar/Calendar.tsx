import { useEffect, useState } from "react";
import FullCalendar from "@fullcalendar/react";
import dayGridPlugin from "@fullcalendar/daygrid";
import timeGridPlugin from "@fullcalendar/timegrid";
import interactionPlugin from "@fullcalendar/interaction";
import listPlugin from "@fullcalendar/list";
import { CalendarContainer } from "../common/components/containers/calendarContainer";
import { useDispatch } from "react-redux";
import { SelectColors, SelectUser } from "../auth/slice";
import { useAppSelector } from "../common/store/rootReducer";
import { getAllEventsAction } from "../event/eventActions";
import { SelectAllEvents } from "../event/selectors";
import { Holiday } from "../holiday/Holiday";

export const Calendar = () => {
  const dispatch = useDispatch();
  let currentUser = useAppSelector((state) => SelectUser(state));
  const [isLogged, setIsLogged] = useState(false);

  useEffect(() => {
    if (currentUser.id != 0  && currentUser.token != "") {
      setIsLogged(true);
      dispatch(getAllEventsAction({ authorId: currentUser.id }));
    } else {
      setIsLogged(false);
    }
  }, [currentUser.token, localStorage]);

  const events = useAppSelector((state) => SelectAllEvents(state));
  const calendarColors = useAppSelector((state) => SelectColors(state));
  const nonDeletedEvents = events.filter((e) => !e.isDeleted);
  const calendar_events = nonDeletedEvents.map((e) => {
    if (
      new Date(e.startEvent).getDate() == new Date(e.endEvent).getDate() &&
      new Date(e.startEvent).getMonth() == new Date(e.endEvent).getMonth() &&
      new Date(e.startEvent).getFullYear() == new Date(e.endEvent).getFullYear()
    ) {
      return {
        title: e.title,
        start: e.startEvent,
        end: e.endEvent,
        color: e.color,
        allDay: true,
        
      };
    }
    return {
      title: e.title,
      start: e.startEvent,
      end: e.endEvent,
      color: e.color,
    };
  });
  const recurringEvents = nonDeletedEvents.map((e) => {
    if (e.isRecurring) {
      const nextStartYear = new Date(e.startEvent).getFullYear();
      const nextEndYear = new Date(e.endEvent).getFullYear();
      const newStartDate = new Date(e.startEvent);
      const newEndDate = new Date(e.endEvent);
      newStartDate.setFullYear(nextStartYear + 1);
      newEndDate.setFullYear(nextEndYear + 1);
      calendar_events.push({
        title: e.title,
        start: newStartDate,
        end: newEndDate,
        color: e.color,
        allDay: true,
      });
    }
  });

  return (
    <>
      <CalendarContainer
        darkmode={calendarColors.isDarkmode}
        color={calendarColors.color}
      >
        <Holiday />
        <FullCalendar
          events={calendar_events}
          eventTimeFormat={{
            hour: "numeric",
            minute: "2-digit",
            meridiem: false,
            hour12: false,
          }}
          plugins={[
            dayGridPlugin,
            timeGridPlugin,
            interactionPlugin,
            listPlugin,
          ]}
          headerToolbar={{
            left: "title",
            center: "",
            right: "",
          }}
          footerToolbar={{
            center: "prev next",
            left: "today",
            right: "prevYear nextYear",
          }}
          initialView="dayGridMonth"
          height={"71.7vh"}
          aspectRatio={2}
          expandRows={true}
          editable={false}
          selectable={false}
          selectMirror={true}
          dayMaxEvents={true}
          weekends={true}
        />
      </CalendarContainer>
    </>
  );
};
