import addEvent from "../../models/event/addEvent";
import getEvent from "../../models/event/getAllEvents";
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
};
