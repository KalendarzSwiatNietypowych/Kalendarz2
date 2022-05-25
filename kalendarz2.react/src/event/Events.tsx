import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { SelectUser } from "../auth/slice";
import { EventsContainer } from "../common/components/containers/EventsContainer";
import { useAppSelector } from "../common/store/rootReducer";

export const Events = () => {
  const navigate = useNavigate();
  let currentUser = useAppSelector((state) => SelectUser(state));
  const [isLogged, setIsLogged] = useState(false);
  useEffect(() => {
    if (localStorage.getItem("userToken") !== null) {
      setIsLogged(true);
    } else {
      setIsLogged(false);
    }
  }, [currentUser.token, localStorage]);
  return (
    <EventsContainer>
      {isLogged && <h2>Here are your events:</h2>}
      {!isLogged && (
        <h2>
          <span onClick={() => navigate("/login")}>Sign in</span> to be able to
          add events
        </h2>
      )}
      {isLogged && (
        <ul>
          <li>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Cumque,
            doloremque suscipit veniam nesciunt voluptatum aperiam dolor esse
            nihil quidem iusto. Accusamus, velit! Nesciunt voluptates, dolor
            vero repellendus asperiores autem recusandae.
          </li>
          <li>event 2</li>
          <li>event 3</li>
          <li>event 4</li>
          <li>event 5</li>
          <li>event 6</li>
        </ul>
      )}
    </EventsContainer>
  );
};
