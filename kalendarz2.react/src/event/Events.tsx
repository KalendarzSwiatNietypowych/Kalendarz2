import { EventsContainer } from "../common/components/containers/EventsContainer";
import {EventsContainerMainText} from "../common/components/containers/EventsContainerMainText";

export const Events = () => {
  return (
    <EventsContainerMainText>
      <h3>Wydarzenia:</h3>
      <h4>Piątek 12.06.2022</h4>
    <EventsContainer>
      <h5>Kolokwium zaliczeniowe</h5>
      <h6>12:00 - 14:00</h6>
      <h6>Politechnika Rzeszowska</h6>
    </EventsContainer>
      <h4>Sobota 13.06.2022</h4>
    <EventsContainer>
      <h5>Kolokwium zaliczeniowe</h5>
      <h6>12:00 - 14:00</h6>
      <h6>Politechnika Rzeszowska</h6>
    </EventsContainer>
      <h4>Niedziela 14.06.2022</h4>
    <EventsContainer>
      <h5>Kolokwium zaliczeniowe</h5>
      <h6>12:00 - 14:00</h6>
      <h6>Politechnika Rzeszowska</h6>
    </EventsContainer>
    </EventsContainerMainText>
  );
};
