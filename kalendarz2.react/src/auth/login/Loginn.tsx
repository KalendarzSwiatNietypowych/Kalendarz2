import { useEffect, useState } from "react";
import { useDispatch } from "react-redux";
import { useNavigate } from "react-router-dom";
import { loginInitialState } from "../../common/models/user/login";
import { useAppSelector } from "../../common/store/rootReducer";
import { SelectUser } from "../slice";
import { loginAction } from "./action";

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

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
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
    <div className="login">
      <h1>Login Page</h1>

      <input
        name="email"
        placeholder="Email"
        value={credits.email}
        required
        onChange={(e) => handleChange(e)}
      />

      <input
        name="password"
        placeholder="Password"
        value={credits.password}
        required
        onChange={(e) => handleChange(e)}
        type="password"
      />

      <button onClick={(e) => handleSubmit(e)}>Submit</button>
    </div>
  );
};
