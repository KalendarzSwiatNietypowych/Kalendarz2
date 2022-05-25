import { createAsyncThunk } from "@reduxjs/toolkit";
import {
  ADD_EVENT, GET_EVENT,
} from "../common/consts/actionTypes";
import addEvent from "../common/models/event/addEvent";
import getAllEvents from "../common/models/event/getAllEvents";
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
export const getAllEventsAction = createAsyncThunk(
  GET_EVENT,
  async (credential: getAllEvents) => {
    try {
      return await eventSrv.getAllEvents(credential);
    } catch (e: any) {
      return e.json();
    }
  }
);
