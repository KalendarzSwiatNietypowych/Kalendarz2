import { Checkbox, FormControlLabel } from "@mui/material";
import { wait } from "@testing-library/user-event/dist/utils";
import moment from "moment";
import { useEffect, useState } from "react";
import { useDispatch } from "react-redux";
import { useNavigate } from "react-router-dom";
import { toast } from "react-toastify";
import { SelectUser } from "../auth/slice";
import { SubmitButton } from "../common/components/buttons/submitButton";
import { AddEventForm } from "../common/components/containers/addEventForm";
import { ColorPallet } from "../common/components/containers/colorPallet";
import { BasicInput } from "../common/components/inputs/basicInput";
import { ColorInput } from "../common/components/inputs/colorInput";
import { StyledCheckbox } from "../common/components/inputs/muiCheckbox";
import { initialState } from "../common/models/event/event";
import { useAppSelector } from "../common/store/rootReducer";

export const Settings = () => {
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
  const navigate = useNavigate();
  const currentAuthorId = useAppSelector((state) => SelectUser(state)).id;

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
    for (let [key, value] of Object.entries(credits)) {
      if (!addEventValidator(key, value)) {
        return;
      }
    }
    if (!dateValidator(credits.startEvent, credits.endEvent)) return;
    // dispatch(
    //   addEventAction({
    //     authorId: credits.authorId,
    //     title: credits.title,
    //     description: credits.description,
    //     location: credits.location,
    //     participantsEmails: credits.participantsEmails,
    //     startEvent: credits.startEvent,
    //     endEvent: credits.endEvent,
    //     color: credits.color,
    //     isRecurring: credits.isRecurring,
    //   })
    // );
    setCredits(initialState);
  };

  const [currentColor, setCurrentColor] = useState(4);

  const handleColorChange = (id: number) => {
    setCurrentColor(id);
  };

  return (
    <AddEventForm darkmode={false}>
      <p>Change your Settings</p>
      <ColorPallet darkmode={false} currentColor = {currentColor}>
        <h2>Choose a color of your Calendar:</h2>
        <div className="red" onClick={() => handleColorChange(0)}></div>
        <div className="orange" onClick={() => handleColorChange(1)}></div>
        <div className="yellow" onClick={() => handleColorChange(2)}></div>
        <div className="green" onClick={() => handleColorChange(3)}></div>
        <div className="default" onClick={() => handleColorChange(4)}></div>
        <div className="blue" onClick={() => handleColorChange(5)}></div>
        <div className="darkblue" onClick={() => handleColorChange(6)}></div>
        <div className="violet" onClick={() => handleColorChange(7)}></div>
      </ColorPallet>
      {/* <BasicInput
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
      <FormControlLabel
        label="Recurring event"
        control={
          <StyledCheckbox
            name="isRecurring"
            checked={checked}
            onChange={() => handleCheckbox()}
          />
        }
      /> */}

      <SubmitButton onClick={(e) => handleSubmit(e)}>Submit</SubmitButton>
    </AddEventForm>
  );
};
