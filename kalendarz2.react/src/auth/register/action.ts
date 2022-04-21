import { createAsyncThunk } from "@reduxjs/toolkit";
import { ADD_USER } from "../../common/consts/actionTypes";
import { authSrv } from "../../common/services/user/authSrv";
import register from "../../common/models/user/register";

export const registerAction = createAsyncThunk(
  ADD_USER,
  async (credential: register) => {
    try {
      return await authSrv.register(credential);
    } catch (e: any) {
      return e.json();
    }
  }
);
