import { api } from "../connectionsString";
import updateSettings from "../../models/user/updateSettings";

const controllerPath = "Account/";

export const SettingsSrv = {
  async update(credential: updateSettings) {
    console.log(credential)
    try {
      return await api
        .put(controllerPath + "edit", credential)
        .then((r) => r.data);
    } catch (e) {
      console.error(e);
    }
  },
};