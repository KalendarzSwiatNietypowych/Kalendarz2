import { createSlice, PayloadAction } from "@reduxjs/toolkit";
import user, { initialState } from "../common/models/user/user";
import { registerAction } from "./register/action";
import { RootState } from "../common/store/rootReducer";
import { loginAction } from "./login/action";

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
            state.id = action.payload.id;
            state.firstName = action.payload.firstName;
            state.lastName = action.payload.lastName;
            state.token = action.payload.token;
          }
        }
      )
      .addCase(
        registerAction.fulfilled,
        (state: user, action: PayloadAction<user>) => {
          if (action.payload !== undefined) {
            localStorage.setItem("userToken", action.payload.token);
            localStorage.setItem("id", action.payload.id.toString());
            localStorage.setItem("firstName", action.payload.firstName);
            localStorage.setItem("lastName", action.payload.lastName);
            state.id = action.payload.id;
            state.firstName = action.payload.firstName;
            state.lastName = action.payload.lastName;
            state.token = action.payload.token;
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
