import { RootState } from "../common/store/rootReducer";

export const SelectAllEvents = (state: RootState) => {
    return state.event.events;
};