import { Checkbox, FormControlLabel } from "@mui/material";
import { wait } from "@testing-library/user-event/dist/utils";
import moment from "moment";
import { useEffect, useState } from "react";
import { useDispatch } from "react-redux";
import { useNavigate } from "react-router-dom";
import { toast } from "react-toastify";
import { updateSourceFile } from "typescript";
import { SelectUser } from "../auth/slice";
import { ActionButton } from "../common/components/buttons/actionButton";
import { SubmitButton } from "../common/components/buttons/submitButton";
import { AddEventForm } from "../common/components/containers/addEventForm";
import { ChangeSettingsForm } from "../common/components/containers/changeSettingsForm";
import { ColorPallet } from "../common/components/containers/colorPallet";
import { BasicInput } from "../common/components/inputs/basicInput";
import { ColorInput } from "../common/components/inputs/colorInput";
import { StyledCheckbox } from "../common/components/inputs/muiCheckbox";
import updateSettings, {
  initialState,
} from "../common/models/user/updateSettings";
import { useAppSelector } from "../common/store/rootReducer";
import { updateSettingsAction } from "./settingsActions";

export const Settings = () => {
  const changeSettingsValidator = (fieldName: string, value: string) => {
    switch (fieldName) {
      case "title":
        if (value) {
          return true;
        }
        toast.error("Please enter a title for Your event");
        return false;
      case "email":
        var emailValidate = value.match(/^([\w.%+-]+)@([\w-]+\.)+([\w]{2,})$/i);
        if (emailValidate) {
          return true;
        }
        toast.error("Please enter a valid email address");
        return false;
      case "firstName":
        if (value.length >= 2) {
          return true;
        }
        toast.error("First name must be at least 2 characters");
        return false;
      case "lastName":
        if (value.length >= 2) {
          return true;
        }
        toast.error("Last name must be at least 2 characters");
        return false;
      default:
        return true;
    }
  };
  const navigate = useNavigate();
  const dispatch = useDispatch();
  const currentUser = useAppSelector((state) => SelectUser(state));
  const [credits, setCredits] = useState(initialState);
  const [checked, setChecked] = useState(false);

  useEffect(() => {
    setCredits({
      userId: currentUser.id,
      firstName: currentUser.firstName,
      lastName: currentUser.lastName,
      email: currentUser.email,
      color: currentUser.color,
      isDarkmode: currentUser.isDarkmode,
    });
    setChecked(currentUser.isDarkmode);
  }, []);

  const handleCheckbox = () => {
    setChecked((prevState) => !prevState);
  };

  const handleChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    const { name, value } = e.target;
    setCredits((prevState) => ({
      ...prevState,
      [name]: value,
    }));
  };

  const handleSubmit = (e: React.MouseEvent<HTMLButtonElement, MouseEvent>) => {
    e.preventDefault();
    credits.isDarkmode = checked;
    credits.color = currentColor;
    for (let [key, value] of Object.entries(credits)) {
      if (!changeSettingsValidator(key, value)) {
        return;
      }
    }
    dispatch(
      updateSettingsAction({
        userId: currentUser.id,
        firstName: credits.firstName,
        lastName: credits.lastName,
        email: credits.email,
        color: credits.color,
        isDarkmode: credits.isDarkmode,
      })
    );
    //setCredits(initialState);
  };

  const [currentColor, setCurrentColor] = useState(currentUser.color);

  const handleColorChange = (id: string) => {
    setCurrentColor(id);
  };

  return (
    <ChangeSettingsForm
      darkmode={currentUser.isDarkmode}
      color={currentUser.color}
    >
      <p>Change your Settings</p>
      <h2>Change your personal data:</h2>
      <BasicInput
        name="firstName"
        placeholder="First Name"
        value={credits.firstName}
        required
        onChange={(e) => handleChange(e)}
      />

      <BasicInput
        name="lastName"
        placeholder="Last Name"
        value={credits.lastName}
        onChange={(e) => handleChange(e)}
      />

      <BasicInput
        name="email"
        placeholder="Email"
        value={credits.email}
        onChange={(e) => handleChange(e)}
      />
      <ColorPallet darkmode={false} currentColor={currentColor}>
        <h2>Choose a color of your Calendar:</h2>
        <div className="colorContainer">
          <div
            className="cherry"
            onClick={() => handleColorChange("#bd1a1a")}
          ></div>
          <h3>Cherry</h3>
        </div>
        <div className="colorContainer">
          <div
            className="orange"
            onClick={() => handleColorChange("#f79322")}
          ></div>
          <h3>Orange</h3>
        </div>
        <div className="colorContainer">
          <div
            className="darkLemon"
            onClick={() => handleColorChange("#bcc543")}
          ></div>
          <h3>Dark Lemon</h3>
        </div>
        <div className="colorContainer">
          <div
            className="monstera"
            onClick={() => handleColorChange("#0f6507")}
          ></div>
          <h3>Monstera</h3>
        </div>
        <div className="colorContainer">
          <div
            className="default"
            onClick={() => handleColorChange("#2BC598")}
          ></div>
          <h3>Default</h3>
        </div>
        <div className="colorContainer">
          <div
            className="sky"
            onClick={() => handleColorChange("#49b5c6")}
          ></div>
          <h3>Sky</h3>
        </div>
        <div className="colorContainer">
          <div
            className="raspberry"
            onClick={() => handleColorChange("#ea3ac3")}
          ></div>
          <h3>Raspberry</h3>
        </div>

        <div className="colorContainer">
          <div
            className="lavender"
            onClick={() => handleColorChange("#ab77bd")}
          ></div>
          <h3>Lavender</h3>
        </div>
      </ColorPallet>

      <FormControlLabel
        label="Darkmode"
        control={
          <StyledCheckbox
            name="darkmode"
            checked={checked}
            onChange={() => handleCheckbox()}
          />
        }
      />

      <SubmitButton
        onClick={(e) => handleSubmit(e)}
        darkmode={false}
        color={currentUser.color}
      >
        Save Changes
      </SubmitButton>
      <ActionButton
        className="new-account"
        onClick={() => navigate("/changePassword")}
      >
        Change password
      </ActionButton>
    </ChangeSettingsForm>
  );
};
