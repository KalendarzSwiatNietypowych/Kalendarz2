import { SidebarContainer } from "../common/components/containers/sidebarContainer";
import CalendarMonthIcon from "@mui/icons-material/CalendarMonth";
import AddIcon from "@mui/icons-material/Add";
import NotificationAddIcon from "@mui/icons-material/NotificationAdd";
import FormatListBulletedIcon from "@mui/icons-material/FormatListBulleted";
import DeleteForeverIcon from "@mui/icons-material/DeleteForever";
import SettingsIcon from "@mui/icons-material/Settings";
import { useNavigate } from "react-router-dom";
type Props = {
  displayIcons: boolean;
};

export const Sidebar = (props: Props) => {
  const handleClick = () => {
    console.log("esf");
  };
  const navigate = useNavigate();
  return (
    <SidebarContainer>
      <div className="main-icon">
        <CalendarMonthIcon onClick={() => navigate("/calendar")} />
      </div>
      <div className="icons">
        {props.displayIcons && <AddIcon onClick={() => navigate("/event")} />}
        {props.displayIcons && <NotificationAddIcon />}
        {props.displayIcons && <FormatListBulletedIcon />}
        {props.displayIcons && <DeleteForeverIcon />}
        {props.displayIcons && <SettingsIcon />}
      </div>
    </SidebarContainer>
  );
};
