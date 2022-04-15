import { createEntityAdapter, createSlice } from "@reduxjs/toolkit";
import holiday from "../common/models/holiday/holiday";
import { RootState } from "../common/store/rootReducer";



const holidaysAdapter = createEntityAdapter<holiday>({
    selectId: (h) => h.id
})
export const {
    selectAll: selectAllHolidays,
    selectIds: selectHolidaysIds,
    selectById: selectHolidayById,
} = holidaysAdapter.getSelectors((state:RootState) => state.holidays) 

const holidaySlice = createSlice({
    name: 'holidays',
    initialState: holidaysAdapter.getInitialState(),
    reducers: {

    },
    extraReducers: b => {

    },
});

export default holidaySlice.reducer;