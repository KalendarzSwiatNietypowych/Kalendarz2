import { useState } from "react";
import { useDispatch } from "react-redux";
import { useNavigate } from "react-router-dom";
import { useAppSelector } from "../../common/store/rootReducer";
import { SelectUser } from "../slice";
import { changePasswordAction } from "./action";
import { BasicInput } from "../../common/components/inputs/basicInput";
import { SubmitButton } from "../../common/components/buttons/submitButton";
import { ActionButton } from "../../common/components/buttons/actionButton";
import { toast } from "react-toastify";
import { initialState } from "../../common/models/user/changePassword";
import { AddEventForm } from "../../common/components/containers/addEventForm";

export const ChangePassword = () => {
  const dispatch = useDispatch();
  const currentUser = useAppSelector((state) => SelectUser(state));
  const navigate = useNavigate();
  const [credits, setCredits] = useState(initialState);
  const [confirmPassword, setConfirmPassword] = useState("");

  const loginValidator = (fieldName: string, value: string) => {
    switch (fieldName) {
      case "email":
        var emailValidate = value.match(/^([\w.%+-]+)@([\w-]+\.)+([\w]{2,})$/i);
        if (emailValidate) {
          return true;
        }
        toast.error("Please enter a valid email address");
        return false;
      case "password":
        if (value.length >= 6) {
          if (value != confirmPassword) {
            toast.error(
              "New password must be the same as confirm new password"
            );
            return false;
          }
          if (value == credits.oldPassword) {
            toast.error(
              "New password has to be diffrenet than Your old passoword"
            );
            return false;
          }
          return true;
        }
        toast.error("Password must be at least 6 characters");
        return false;
      default:
        return true;
    }
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

  const handleSubmit = (
    event: React.MouseEvent<HTMLButtonElement, MouseEvent>
  ) => {
    event.preventDefault();
    for (let [key, value] of Object.entries(credits)) {
      if (!loginValidator(key, value)) {
        return;
      }
    }
    credits.userId = currentUser.id;
    dispatch(changePasswordAction(credits));
    setCredits(initialState);
    setConfirmPassword("");
  };

  return (
    <AddEventForm darkmode={currentUser.isDarkmode} color={currentUser.color}>
      <p>Change your password</p>

      <BasicInput
        name="oldPassword"
        placeholder="Current password"
        value={credits.oldPassword}
        required
        onChange={(e) => handleChange(e)}
        type="password"
      />

      <BasicInput
        name="password"
        placeholder="New password"
        value={credits.password}
        required
        onChange={(e) => handleChange(e)}
        type="password"
      />
      <BasicInput
        name="confirmPassword"
        placeholder="Confirm new password"
        value={confirmPassword}
        required
        onChange={(e) => setConfirmPassword(e.target.value)}
        type="password"
      />
      <SubmitButton
        onClick={(e) => handleSubmit(e)}
        darkmode={false}
        color={currentUser.color}
      >
        Submit
      </SubmitButton>
      <ActionButton
        className="new-account"
        onClick={() => navigate("/settings")}
      >
        Go back to settings
      </ActionButton>
    </AddEventForm>
  );
};
