import moment from "moment";
import { useEffect, useState } from "react";
import { useDispatch } from "react-redux";
import { useNavigate } from "react-router-dom";
import { SubmitButton } from "../common/components/buttons/submitButton";
import { LoginFormContainer } from "../common/components/containers/loginFormContainer";
import { BasicInput } from "../common/components/inputs/basicInput";

import { holidayInitialState } from "../common/models/holiday/holiday";

export const Event = () => {
  const dispatch = useDispatch();
  const navigate = useNavigate();
  const [credits, setCredits] = useState(holidayInitialState);

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
    console.log(credits);
    console.log(moment(credits.endDate).format("yyyy-MM-DDTHH:mm"));
  };

  return (
    <LoginFormContainer>
      <p>Add Event</p>

      <BasicInput
        name="name"
        placeholder="Name"
        value={credits.name}
        required
        onChange={(e) => handleChange(e)}
      />

      <BasicInput
        name="startDate"
        value={moment(credits.startDate).format("yyyy-MM-DDTHH:mm")}
        required
        onChange={(e) => handleChange(e)}
        type="datetime-local"
      />

      <BasicInput
        name="endDate"
        value={moment(credits.endDate).format("yyyy-MM-DDThh:mm")}
        required
        onChange={(e) => handleChange(e)}
        type="datetime-local"
      />

      <BasicInput
        name="description"
        placeholder="description"
        value={credits.description}
        required
        onChange={(e) => handleChange(e)}
      />
      <SubmitButton onClick={(e) => handleSubmit(e)}>Submit</SubmitButton>
      <h2>Do not have an account?</h2>
    </LoginFormContainer>
  );
};
