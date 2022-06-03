import { createAsyncThunk } from "@reduxjs/toolkit";
import {
  ADD_EVENT, DELETE_EVENT, GET_EVENT, UPDATE_EVENT,
} from "../common/consts/actionTypes";
import addEvent from "../common/models/event/addEvent";
import deleteEvent from "../common/models/event/deleteEvent";
import getAllEvents from "../common/models/event/getAllEvents";
import updateEvent from "../common/models/event/updateEvent";
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

export const updateEventAction = createAsyncThunk(
  UPDATE_EVENT,
  async (credential: updateEvent) => {
    try {
      return await eventSrv.updateEvent(credential);
    } catch (e: any) {
      return e.json();
    }
  }
);

export const deleteEventAction = createAsyncThunk(
  DELETE_EVENT,
  async (credential: deleteEvent) => {
    try {
      return await eventSrv.deleteEvent(credential);
    } catch (e: any) {
      return e.json();
    }
  }
);
