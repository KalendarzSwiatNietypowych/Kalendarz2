import { createSlice } from "@reduxjs/toolkit";
import { initialState } from "../common/models/holiday/holidays";
import { getHolidayAction } from "./holidayActions";

export const holidaySlice = createSlice({
  name: "holiday",
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(getHolidayAction.fulfilled, (state, action) => {
        if (action.payload !== undefined) {
          state.holidays = action.payload;
        }
      })

  },
});

export default holidaySlice.reducer;