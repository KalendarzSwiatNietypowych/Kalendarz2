import { applyMiddleware } from "redux";
import getHoliday from "../../models/holiday/getholiday";
import { api } from "../connectionsString";

const controllerPath = "holiday/";

export const holidaySrv = {
    async getHoliday(credential:getHoliday){
        try {
            return await api
            .post(controllerPath + "get", credential)
            .then((r) => r.data);
        } catch (e){
            console.error(e);
        }
    },
    
}