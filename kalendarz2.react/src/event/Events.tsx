import { EventsContainer } from "../common/components/containers/EventsContainer";
import {EventsContainerMainText} from "../common/components/containers/EventsContainerMainText";
import AddLocationAltRoundedIcon from '@mui/icons-material/AddLocationAltRounded';


const dates=["Kolokwium zaliczeniowe", "Egzamin pisemny", "Egzamin ustny", "Mecz piłki nożnej", "xddd", "sdsdsds", "dffff"]
const dateslist=dates.map(date=><EventsContainer><h5>{date}</h5><h6>12:00 - 14:00</h6><h6>Politechnika Rzeszowska</h6><div className="icon">
<AddLocationAltRoundedIcon />
</div></EventsContainer>)

export const Events = () => {
  return (
    <EventsContainerMainText>
      <h3>Wydarzenia:</h3>
      {dateslist}
    </EventsContainerMainText>
  );
};
