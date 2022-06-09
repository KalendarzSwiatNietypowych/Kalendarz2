import { useEffect } from "react";
import { useDispatch } from "react-redux";
import { HolidayContainer } from "../common/components/containers/holidayContainer";
import { useAppSelector } from "../common/store/rootReducer";
import { getHolidayAction } from "./holidayActions";
import { SelectAllHolidays } from "./selectors";
export const Holiday = () => {
  const dispatch = useDispatch();
  useEffect(() => {
    dispatch(getHolidayAction({}));
  }, []);

  const holidays = useAppSelector((state) => SelectAllHolidays(state));
  const todaysHoliday = holidays.find(
    (h) =>
      new Date(h.date).getDate() == new Date().getDate() &&
      new Date(h.date).getMonth() == new Date().getMonth()
  );

  return (
    <HolidayContainer>
      <div>
        <h1>Today's unusual holiday:</h1>
        <h2>{todaysHoliday?.name}</h2>
      </div>
      <div className="description">
        <h3>{todaysHoliday?.description}</h3>
      </div>

      <img src="https://imgs.search.brave.com/t6ARkWBupvrIpb6pHG4uvgbZGlgQ5WAfzXEMNhBCoJI/rs:fit:512:512:1/g:ce/aHR0cDovL3d3dy5l/bW9qaS5jby51ay9m/aWxlcy9nb29nbGUt/ZW1vamlzL29iamVj/dHMtYW5kcm9pZC83/OTE2LWNhbGVuZGFy/LnBuZw" />
    </HolidayContainer>
  );
};
