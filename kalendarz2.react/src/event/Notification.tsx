import { useEffect, useState } from "react";
import EventIcon from "@mui/icons-material/Event";
import moment from "moment";
import { NotificationContainer } from "../common/components/containers/NotificationContainer";
import event from "../common/models/event/event";

type Props = {
  bcolor: string;
  event: event;
  today: boolean;
};

export const Notification = (props: Props) => {
  const [startsIn, setStartsIn] = useState(<h3 className="bold"></h3>);
  var dateInterval: NodeJS.Timer;
  useEffect(() => {
    dateInterval = setInterval(() => handleDate(props.event.startEvent), 1000);
  }, []);
  const handleDate = (startEvent: Date) => {
    var now = new Date().getTime();
    var distance = new Date(startEvent).getTime() - now;

    var hours = Math.floor(
      (distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60)
    );

    var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
    var seconds = Math.floor((distance % (1000 * 60)) / 1000);
    if (hours <= 0) {
      if (minutes <= 0) {
        if (seconds <= 0) {
          setStartsIn(<h3 className="bold">Event has just started</h3>);
          clearInterval(dateInterval);
        } else {
          setStartsIn(<h3 className="bold">Starts in:{seconds}s</h3>);
        }
      } else {
        setStartsIn(
          <h3 className="bold">
            Starts in: {minutes}m {seconds}s
          </h3>
        );
      }
    } else {
      setStartsIn(
        <h3>
          Starts in: {hours}h {minutes}m {seconds}s
        </h3>
      );
    }
  };

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

  return (
    <NotificationContainer
      bcolor={props.event.color}
      textColor={calculateColor(props.event.color)!}
    >
      <div className="eventTitle">
        <h2>{props.event.title}</h2>
        <EventIcon />
      </div>
      <h3>{props.event.description}</h3>
      {startsIn}
      <h3>Ends: {moment(props.event.endEvent).format("DD-MM-yyyy HH:mm")}</h3>
    </NotificationContainer>
  );
};
