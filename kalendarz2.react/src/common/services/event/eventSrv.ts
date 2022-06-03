import addEvent from "../../models/event/addEvent";
import deleteEvent from "../../models/event/deleteEvent";
import getEvent from "../../models/event/getAllEvents";
import updateEvent from "../../models/event/updateEvent";
import { api } from "../connectionsString";

const controllerPath = "Event/";

export const eventSrv = {
  async addEvent(credential: addEvent) {
    try {
      return await api
        .post(controllerPath + "create", credential)
        .then((r) => r.data);
    } catch (e) {
      console.error(e);
    }
  },
  async getAllEvents(credential: getEvent) {
    try {
      return await api
        .post(controllerPath + "getByUser", credential)
        .then((r) => r.data);
    } catch (e) {
      console.error(e);
    }
  },
  async updateEvent(credential: updateEvent) {
    try {
      return await api
        .put(controllerPath + "update", credential)
        .then((r) => r.data);
    } catch (e) {
      console.error(e);
    }
  },
  async deleteEvent(credential: deleteEvent) {
    try {
      return await api
        .put(controllerPath + "delete", credential)
        .then((r) => r.data);
    } catch (e) {
      console.error(e);
    }
  },
};
