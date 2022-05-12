import { ImportantEventsContainer } from "../common/components/containers/ImportantEventsContainer";
import { ImportantEventsList } from "../common/components/containers/importantEventsList";

export const ImportantEvents = () => {
  return (
    <ImportantEventsContainer>
      <h4>Important events:</h4>
      <ImportantEventsList>
        <ul>
          <li>event 1</li>
          <li>event 2</li>
          <li>event 3</li>
          <li>event 4</li>
          <li>event 5</li>
          <li>event 6</li>
        </ul>
      </ImportantEventsList>
    </ImportantEventsContainer>
  );
};
