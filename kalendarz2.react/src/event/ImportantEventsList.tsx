import { ImportantEventsContainer } from "../common/components/containers/ImportantEventsContainer";
import { ImportantEventsList } from "../common/components/containers/importantEventsList";

export const ImportantEvents = () => {
  return (
    <ImportantEventsContainer>
      <h4>Important events:</h4>
      <ImportantEventsList darkmode={false}>
        <ul>
          <li>
            Zbiórka pieniędzy dla kotków, które potrzebują pieniędzy, bo są
            troszkę głodne
          </li>
          <li>event 2</li>
          <li>event 3</li>
          <li>event 4</li>
          <li>event 5</li>
          <li>event 6</li>
        </ul>
      </ImportantEventsList>
      <img src="https://imgs.search.brave.com/t6ARkWBupvrIpb6pHG4uvgbZGlgQ5WAfzXEMNhBCoJI/rs:fit:512:512:1/g:ce/aHR0cDovL3d3dy5l/bW9qaS5jby51ay9m/aWxlcy9nb29nbGUt/ZW1vamlzL29iamVj/dHMtYW5kcm9pZC83/OTE2LWNhbGVuZGFy/LnBuZw" />
    </ImportantEventsContainer>
  );
};
