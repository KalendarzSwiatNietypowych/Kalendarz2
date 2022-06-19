import { createAsyncThunk } from "@reduxjs/toolkit";
import { VERIFY_EMAIL } from "../../common/consts/actionTypes";
import { authSrv } from "../../common/services/user/authSrv";
import register from "../../common/models/user/register";

export const verifyEmailAction = createAsyncThunk(
  VERIFY_EMAIL,
  async (credential: number) => {
    try {
      return await authSrv.verifyEmail(credential);
    } catch (e: any) {
      return e.json();
    }
  }
);
