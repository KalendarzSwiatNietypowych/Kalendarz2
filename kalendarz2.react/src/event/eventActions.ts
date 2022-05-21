import { createAsyncThunk } from "@reduxjs/toolkit";
import {
  ADD_EVENT,
} from "../common/consts/actionTypes";
import addEvent from "../common/models/event/addEvent";
import { eventSrv } from "../common/services/event/eventSrv";

export const addEventAction = createAsyncThunk(
    ADD_EVENT,
  async (credential: addEvent) => {
    try {
      return await eventSrv.addEvent(credential);
    } catch (e: any) {
      return e.json();
    }
  }
);
