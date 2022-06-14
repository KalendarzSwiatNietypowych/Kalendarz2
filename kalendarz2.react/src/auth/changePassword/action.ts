import { createAsyncThunk } from "@reduxjs/toolkit";
import { CHANGE_PASSWORD, FETCH_USER } from "../../common/consts/actionTypes";
import changePassword from "../../common/models/user/changePassword";
import { authSrv } from "../../common/services/user/authSrv";

export const changePasswordAction = createAsyncThunk(
  CHANGE_PASSWORD,
  async (credentials: changePassword) => {
    try {
      return await authSrv.changePassword(credentials);
    } catch (e: any) {
      return e.json();
    }
  }
);