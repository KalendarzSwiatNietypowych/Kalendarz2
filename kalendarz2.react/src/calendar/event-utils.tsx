import { EventInput } from "@fullcalendar/react";
import { useEffect, useState } from "react";
import { useDispatch } from "react-redux";
import { SelectUser } from "../auth/slice";
import { useAppSelector } from "../common/store/rootReducer";
import { getAllEventsAction } from "../event/eventActions";
import { SelectAllEvents } from "../event/selectors";

// const dispatch = useDispatch();
// let currentUser = useAppSelector((state) => SelectUser(state));
// const [isLogged, setIsLogged] = useState(false);

// useEffect(() => {
//   if (localStorage.getItem("userToken") !== null) {
//     setIsLogged(true);
//     dispatch(getAllEventsAction({ authorId: currentUser.id }));
//   } else {
//     setIsLogged(false);
//   }
// }, [currentUser.token, localStorage]);

// const events = useAppSelector((state) => SelectAllEvents(state));
// const calendar_events = events.map((e) => {
//   return {
//     title: e.title,
//     start: e.startEvent,
//   };
// });

// console.log(calendar_events);

export const INITIAL_EVENTS: EventInput[] = [
  {
    id: "1",
    title: "All-day event",
    start: "T12:00:00",
  },
  {
    id: "2",
    title: "Timed event",
    start: "T12:00:00",
  },
];
