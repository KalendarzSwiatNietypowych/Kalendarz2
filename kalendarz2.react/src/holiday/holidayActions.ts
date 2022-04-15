import { createAsyncThunk } from "@reduxjs/toolkit";
import { GET_HOLIDAY } from "../common/consts/actionTypes";
import getHoliday from "../common/models/holiday/getholiday";
import { holidaySrv } from "../common/services/holiday/holidaySrv";

export const getHolidayAction = createAsyncThunk(
    GET_HOLIDAY,
    async (credential: getHoliday) => {
      try {
        return await holidaySrv.getHoliday(credential);
      } catch (e: any) {
        return e.json();
      }
    }
  );