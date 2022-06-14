import register from "../../models/user/register";
import login from "../../models/user/login";
import { api } from "../connectionsString";
import changePassword from "../../models/user/changePassword";

const controllerPath = "account/";

export const authSrv = {
  async login(credential: login) {
    try {
      return await api
        .post(controllerPath + "login", credential)
        .then((r) => r.data);
    } catch (e) {
      console.error(e);
    }
  },

  async register(credential: register) {
    try {
      return await api
        .post(controllerPath + "register", credential)
        .then((r) => r.data);
    } catch (e) {
      console.error(e);
    }
    },
    async changePassword(credential: changePassword) {
      try {
        return await api
          .post(controllerPath + "changePassword", credential)
          .then((r) => r.data);
      } catch (e) {
        console.error(e);
      }
    },
};
