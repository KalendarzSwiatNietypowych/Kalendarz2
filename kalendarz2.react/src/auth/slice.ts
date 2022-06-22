import { createSlice, PayloadAction } from "@reduxjs/toolkit";
import user, { initialState } from "../common/models/user/user";
import { registerAction } from "./register/action";
import { RootState } from "../common/store/rootReducer";
import { loginAction } from "./login/action";
import { updateSettingsAction } from "../settings/settingsActions";

export const authSlice = createSlice({
  name: "auth",
  initialState,
  reducers: {
    loadLocalStorage(state) {
      if (localStorage.getItem("id") !== null) {
        state.id = parseInt(localStorage.getItem("id")!);
        state.lastName = localStorage.getItem("lastName")!;
        state.firstName = localStorage.getItem("firstName")!;
        state.token = localStorage.getItem("userToken")!;
        state.email = localStorage.getItem("email")!;
        state.color = localStorage.getItem("color")!;
        state.isDarkmode = localStorage.getItem("isDarkmode")! == "true"? true:false;
      }
    },
  },
  extraReducers: (builder) => {
    builder
      .addCase(
        loginAction.fulfilled,
        (state: user, action: PayloadAction<user, string>) => {
          if (action.payload !== undefined) {
            localStorage.setItem("userToken", action.payload.token);
            localStorage.setItem("id", action.payload.id.toString());
            localStorage.setItem("firstName", action.payload.firstName);
            localStorage.setItem("lastName", action.payload.lastName);
            localStorage.setItem("email", action.payload.email);
            localStorage.setItem("color", action.payload.color);
            localStorage.setItem("isDarkmode", action.payload.isDarkmode.toString());
            state.id = action.payload.id;
            state.firstName = action.payload.firstName;
            state.lastName = action.payload.lastName;
            state.token = action.payload.token;
            state.email = action.payload.email;
            state.color = action.payload.color;
            state.isDarkmode = action.payload.isDarkmode;
          }
        }
      )
      .addCase(
        updateSettingsAction.fulfilled,
        (state, action) => {
          if (action.payload !== undefined) {
            localStorage.setItem("color", action.payload.color);
            localStorage.setItem("email", action.payload.email);
            localStorage.setItem("firstName", action.payload.firstName);
            localStorage.setItem("lastName", action.payload.lastName);
            localStorage.setItem("isDarkmode", action.payload.isDarkmode);
            state.color = action.payload.color;
            state.email = action.payload.email;
            state.firstName = action.payload.firstName;
            state.lastName = action.payload.lastName;
            state.isDarkmode = action.payload.isDarkmode;
          }
        }
      )

  },
});

export const { loadLocalStorage } = authSlice.actions;
export default authSlice.reducer;

export const SelectUser = (state: RootState) => {
  return state.currentUser
};

export const SelectColors = (state: RootState) =>{
  return {
    color:state.currentUser.color,
    isDarkmode:state.currentUser.isDarkmode
  }
}
