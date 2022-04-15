import { combineReducers } from "@reduxjs/toolkit";
import { TypedUseSelectorHook, useSelector } from "react-redux";
import holidaysReducer from "../../holiday/slice"

const rootReducer = combineReducers({
    // currentUser: authReducer,
    // eventsBucket: eventsBucketReducer,
    holidays: holidaysReducer,
});

export default rootReducer;
export type RootState = ReturnType<typeof rootReducer>;
export const useAppSelector: TypedUseSelectorHook<RootState> = useSelector;