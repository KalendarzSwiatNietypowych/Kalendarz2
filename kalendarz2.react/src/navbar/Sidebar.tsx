import { SidebarContainer } from "../common/components/containers/sidebarContainer";
import CalendarMonthIcon from "@mui/icons-material/CalendarMonth";
import AddIcon from "@mui/icons-material/Add";
import NotificationAddIcon from "@mui/icons-material/NotificationAdd";
import FormatListBulletedIcon from "@mui/icons-material/FormatListBulleted";
import DeleteForeverIcon from "@mui/icons-material/DeleteForever";
import SettingsIcon from "@mui/icons-material/Settings";
import { useNavigate } from "react-router-dom";
export const Sidebar = () => {
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
        <AddIcon onClick={handleClick} />
        <NotificationAddIcon />
        <FormatListBulletedIcon />
        <DeleteForeverIcon />
        <SettingsIcon />
      </div>
    </SidebarContainer>
  );
};
