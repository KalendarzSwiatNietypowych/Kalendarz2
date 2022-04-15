import { useState } from "react";
import { CalendarStyle } from "../common/components/Calendar";

export const CalendarContainer = () => {
  const [selectedDate, setSelectedDate] = useState(new Date());

  const handleDateChange = (date: Date) => {
    setSelectedDate(date);
    console.log("Date is: ", selectedDate);
  };

  return (
    <div className="calendar">
      <h1>Calendar Page</h1>
      <CalendarStyle onChange={handleDateChange} />
    </div>
  );
};
