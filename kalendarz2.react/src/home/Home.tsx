import { useState } from "react";
import { useNavigate } from "react-router-dom";

export const Home = () => {
  const navigate = useNavigate();
  const today = new Date();
  const [currentDate, setCurrentDate] = useState(today);

  const handleClick = (add: boolean) => {
    const newDate = new Date(currentDate);
    newDate.setDate(newDate.getDate() + (add ? 1 : -1));
    setCurrentDate(newDate);
  };

  const eventsList = [
    {
      id: 0,
      name: "Święto Pracy",
      date: new Date("May 1, 2022"),
      description: "Święto pracy jest bla bla bla bla",
    },
    {
      id: 1,
      name: "Święto Pracy2",
      date: new Date("May 1, 2022"),
      description: "Święto pracy jest bla bla bla bla22222",
    },
    {
      id: 2,
      name: "Święto Flagi",
      date: new Date("May 2, 2022"),
      description: "Święto flagi jest bla bla bla bla",
    },
  ];

  return (
    <div className="home">
      <h3>Today's events and holidays:</h3>
      <h2>{currentDate.toLocaleDateString()}</h2>
      {eventsList.map((event) => {
        console.log(event.date);
        console.log(currentDate);
        if (
          event.date.getDate() === currentDate.getDate() &&
          event.date.getMonth() === currentDate.getMonth() &&
          event.date.getFullYear() === currentDate.getFullYear()
        ) {
          return (
            <div>
              <h2>{event.name}</h2>
              <p>{event.description}</p>
            </div>
          );
        }
      })}
      <button onClick={() => handleClick(false)}>Before</button>
      <button onClick={() => handleClick(true)}>After</button>
      <button onClick={() => navigate("/event")}>Add Event</button>
    </div>
  );
};
