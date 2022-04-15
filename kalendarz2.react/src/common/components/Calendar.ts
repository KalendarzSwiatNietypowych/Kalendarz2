import Calendar from "react-calendar";
import styled from "styled-components";

export const CalendarStyle = styled(Calendar)`
  &&& {
    .react-calendar__tile {
      height: 2rem;
    }
    .react-calendar__viewContainer {
      width: 20%;
      margin: 0 auto;
    }
  }
`;
