import { createAsyncThunk } from "@reduxjs/toolkit";
import { UPDATE_SETTINGS } from "../common/consts/actionTypes";
import updateSettings from "../common/models/user/updateSettings";
import { SettingsSrv } from "../common/services/user/settingsSrv";

export const updateSettingsAction = createAsyncThunk(
    UPDATE_SETTINGS,
  async (credential: updateSettings) => {
    try {
      return await SettingsSrv.update(credential);
    } catch (e: any) {
      return e.json();
    }
  }
);