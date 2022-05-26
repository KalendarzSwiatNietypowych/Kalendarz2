import { Checkbox, FormControlLabel } from "@mui/material";
import { wait } from "@testing-library/user-event/dist/utils";
import moment from "moment";
import { useEffect, useState } from "react";
import { useDispatch } from "react-redux";
import { useNavigate } from "react-router-dom";
import { SelectUser } from "../auth/slice";
import { SubmitButton } from "../common/components/buttons/submitButton";
import { AddEventForm } from "../common/components/containers/addEventForm";
import { BasicInput } from "../common/components/inputs/basicInput";
import { initialState } from "../common/models/event/event";
import { useAppSelector } from "../common/store/rootReducer";
import { addEventAction, getAllEventsAction } from "./eventActions";

export const AddEvent = () => {
  const dispatch = useDispatch();
  const navigate = useNavigate();
  const currentAuthorId = useAppSelector((state) => SelectUser(state)).id;

  const [credits, setCredits] = useState(initialState);
  const [checked, setChecked] = useState(false);

  const handleCheckbox = () => {
    setChecked(!checked);
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
    credits.authorId = currentAuthorId;
    credits.participantsEmails = [];
    credits.isRecurring = checked;
    dispatch(
      addEventAction({
        authorId: credits.authorId,
        title: credits.title,
        description: credits.description,
        location: credits.location,
        participantsEmails: credits.participantsEmails,
        startEvent: credits.startEvent,
        endEvent: credits.endEvent,
        color: credits.color,
        isRecurring: credits.isRecurring,
      })
    );
    console.log(credits);
    setCredits(initialState);
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
        name="startEvent"
        value={moment(credits.startEvent).format("yyyy-MM-DDTHH:mm")}
        required
        onChange={(e) => handleChange(e)}
        type="datetime-local"
      />

      <BasicInput
        name="endEvent"
        value={moment(credits.endEvent).format("yyyy-MM-DDTHH:mm")}
        required
        onChange={(e) => handleChange(e)}
        type="datetime-local"
      />

      <input
        type="color"
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
            checked={checked}
            onChange={() => handleCheckbox()}
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
    </AddEventForm>
  );
};
