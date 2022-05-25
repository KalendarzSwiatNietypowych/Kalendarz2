import { combineReducers } from "@reduxjs/toolkit";
import { TypedUseSelectorHook, useSelector } from "react-redux";
import holidaysReducer from "../../holiday/slice"
import authReducer from "../../auth/slice"
import eventReducer from "../../event/slice"
const rootReducer = combineReducers({
    currentUser: authReducer,
    event: eventReducer,
    holidays: holidaysReducer,
});

export default rootReducer;
export type RootState = ReturnType<typeof rootReducer>;
export const useAppSelector: TypedUseSelectorHook<RootState> = useSelector;