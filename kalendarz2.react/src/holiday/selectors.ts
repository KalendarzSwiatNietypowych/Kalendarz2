import { RootState } from "../common/store/rootReducer";

export const SelectAllHolidays = (state: RootState) => {
    return state.holidays.holidays;
};