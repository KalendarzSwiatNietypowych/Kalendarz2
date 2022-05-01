import { useEffect, useState } from "react";
import { useDispatch } from "react-redux";
import { useNavigate } from "react-router-dom";
import { LoginFormContainer } from "../../common/components/containers/loginFormContainer";
import { loginInitialState } from "../../common/models/user/login";
import { useAppSelector } from "../../common/store/rootReducer";
import { SelectUser } from "../slice";
import { loginAction } from "./action";
import { BasicInput } from "../../common/components/inputs/basicInput";
import { SubmitButton } from "../../common/components/containers/buttons/submitButton";
import { ActionButton } from "../../common/components/containers/buttons/actionButton";
export const Login = () => {
  const dispatch = useDispatch();
  const currentUser = useAppSelector((state) => SelectUser(state));
  const navigate = useNavigate();
  const [credits, setCredits] = useState(loginInitialState);

  useEffect(() => {
    if (currentUser.token !== "") {
      navigate("../", { replace: true });
    }
  }, [currentUser.token, navigate]);

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
    dispatch(loginAction(credits));
  };

  return (
    <LoginFormContainer>
      <p>Sign In</p>

      <BasicInput
        name="email"
        placeholder="Email"
        value={credits.email}
        required
        onChange={(e) => handleChange(e)}
      />

      <BasicInput
        name="password"
        placeholder="Password"
        value={credits.password}
        required
        onChange={(e) => handleChange(e)}
        type="password"
      />
      <SubmitButton onClick={(e) => handleSubmit(e)}>Submit</SubmitButton>
      <h2>Do not have an account?</h2>
      <ActionButton
        className="new-account"
        onClick={() => navigate("/register")}
      >
        Create an account
      </ActionButton>
    </LoginFormContainer>
  );
};
