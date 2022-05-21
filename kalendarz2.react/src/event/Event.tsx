import { Checkbox, FormControlLabel } from "@mui/material";
import moment from "moment";
import { useEffect, useState } from "react";
import { useDispatch } from "react-redux";
import { useNavigate } from "react-router-dom";
import { SelectUser } from "../auth/slice";
import { SubmitButton } from "../common/components/buttons/submitButton";
import { AddEventForm } from "../common/components/containers/addEventForm";
import { BasicInput } from "../common/components/inputs/basicInput";
import { eventInitialState } from "../common/models/event/event";
import { useAppSelector } from "../common/store/rootReducer";
import { addEventAction } from "./eventActions";

export const Event = () => {
  const dispatch = useDispatch();
  const navigate = useNavigate();
  const [credits, setCredits] = useState(eventInitialState);

  const handleChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    const { name, value } = e.target;
    setCredits((prevState) => ({
      ...prevState,
      [name]: value,
    }));
  };

  const currentAuthorId = useAppSelector((state) => SelectUser(state)).id;

  const handleSubmit = (e: React.MouseEvent<HTMLButtonElement, MouseEvent>) => {
    credits.authorId = currentAuthorId;
    console.log(credits);
    dispatch(
      addEventAction({
        authorId: credits.authorId,
        title: credits.title,
        description: credits.description,
        location: credits.location,
        participantsEmails: credits.participantsEmails,
        startDate: credits.startDate,
        endDate: credits.endDate,
        color: credits.color,
        isRecurring: credits.isRecurring,
      })
    );
    console.log(moment(credits.endDate).format("yyyy-MM-DDTHH:mm"));
  };

  return (
    <AddEventForm>
      <p>Add Event</p>

      <BasicInput
        name="title"
        placeholder="Title"
        value={credits.title}
        required
        onChange={(e) => handleChange(e)}
      />

      <BasicInput
        name="location"
        placeholder="Location"
        value={credits.location}
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
        value={moment(credits.endDate).format("yyyy-MM-DDTHH:mm")}
        required
        onChange={(e) => handleChange(e)}
        type="datetime-local"
      />

      <BasicInput
        name="color"
        placeholder="Color"
        value={credits.color}
        required
        onChange={(e) => handleChange(e)}
      />
      <FormControlLabel
        label="Recurring event"
        control={
          <Checkbox
            name="isRecurring"
            value={credits.isRecurring}
            onChange={(e) => handleChange(e)}
          />
        }
      />

      <BasicInput
        name="description"
        placeholder="Description"
        value={credits.description}
        required
        onChange={(e) => handleChange(e)}
      />
      <SubmitButton onClick={(e) => handleSubmit(e)}>Submit</SubmitButton>
      <h2>Do not have an account?</h2>
    </AddEventForm>
  );
};
