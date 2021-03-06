import { FormControlLabel } from "@mui/material";
import moment from "moment";
import { useState } from "react";
import { useDispatch } from "react-redux";
import { useNavigate } from "react-router-dom";
import { toast } from "react-toastify";
import { SelectColors, SelectUser } from "../auth/slice";
import { SubmitButton } from "../common/components/buttons/submitButton";
import { AddEventForm } from "../common/components/containers/addEventForm";
import { BasicInput } from "../common/components/inputs/basicInput";
import { ColorInput } from "../common/components/inputs/colorInput";
import { StyledCheckbox } from "../common/components/inputs/muiCheckbox";
import { initialState } from "../common/models/event/event";
import { useAppSelector } from "../common/store/rootReducer";
import { addEventAction } from "./eventActions";
import HelpIcon from "@mui/icons-material/Help";

export const AddEvent = () => {
  const addEventValidator = (fieldName: string, value: string) => {
    switch (fieldName) {
      case "title":
        if (value) {
          return true;
        }
        toast.error("Please enter a title for Your event");
        return false;
      default:
        return true;
    }
  };

  const dateValidator = (startEvent: Date, endEvent: Date) => {
    if (startEvent > endEvent) {
      toast.error("Please enter a valid date");
      return false;
    }
    return true;
  };
  const dispatch = useDispatch();

  const currentAuthorId = useAppSelector((state) => SelectUser(state)).id;
  const calendarColors = useAppSelector((state) => SelectColors(state));

  const [credits, setCredits] = useState(initialState);
  const [checked, setChecked] = useState(false);
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
    credits.authorId = currentAuthorId;
    credits.participantsEmails = [];
    credits.isRecurring = checked;
    credits.isDeleted = false;
    for (let [key, value] of Object.entries(credits)) {
      if (!addEventValidator(key, value)) {
        return;
      }
    }
    if (!dateValidator(credits.startEvent, credits.endEvent)) return;
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
        isDeleted: credits.isDeleted,
      })
    );
    setCredits(initialState);
    setChecked(false);
  };

  return (
    <AddEventForm
      darkmode={calendarColors.isDarkmode}
      color={calendarColors.color}
    >
      <p>Add Event</p>

      <BasicInput
        name="title"
        placeholder="Title"
        value={credits.title}
        required
        onChange={(e) => handleChange(e)}
      />

      <BasicInput
        name="description"
        placeholder="Description"
        value={credits.description}
        onChange={(e) => handleChange(e)}
      />

      <BasicInput
        name="location"
        placeholder="Location"
        value={credits.location}
        onChange={(e) => handleChange(e)}
      />

      <BasicInput
        name="startEvent"
        value={moment(credits.startEvent).format("yyyy-MM-DDTHH:mm")}
        onChange={(e) => handleChange(e)}
        type="datetime-local"
      />

      <BasicInput
        name="endEvent"
        value={moment(credits.endEvent).format("yyyy-MM-DDTHH:mm")}
        onChange={(e) => handleChange(e)}
        type="datetime-local"
      />
      <FormControlLabel
        label="Choose event color"
        control={
          <ColorInput
            type="color"
            name="color"
            placeholder="Color"
            value={credits.color}
            required
            onChange={(e) => handleChange(e)}
          />
        }
      />
      <div className="recurringDiv">
        <FormControlLabel
          label="Recurring event"
          control={
            <StyledCheckbox
              name="isRecurring"
              checked={checked}
              onChange={() => handleCheckbox()}
            />
          }
        />
        <div className="iconDiv">
          <HelpIcon fontSize="small" className="helpIcon" />
          <h5 className="recurring">
            Event will also happen at the same time next year.
          </h5>
        </div>
      </div>

      <SubmitButton
        onClick={(e) => handleSubmit(e)}
        darkmode={false}
        color={calendarColors.color}
      >
        Submit
      </SubmitButton>
    </AddEventForm>
  );
};
