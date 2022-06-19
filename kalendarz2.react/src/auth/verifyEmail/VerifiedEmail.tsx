import { useDispatch } from "react-redux";
import { useParams } from "react-router-dom";
import { InfoContainer } from "../../common/components/containers/infoContainer";
import { useAppSelector } from "../../common/store/rootReducer";
import { SelectUser } from "../slice";
import { verifyEmailAction } from "./action";

export const VerifiedEmail = () => {
  const isDarkmode = useAppSelector((state) => SelectUser(state)).isDarkmode;
  const userId = Number(useParams().userId);
  const dispatch = useDispatch();
  dispatch(verifyEmailAction(userId));
  
  return (
    <InfoContainer darkmode={isDarkmode}>
      <p>Your email has been verified,</p>
      <p>be welcome to login and use our calendar!</p>
    </InfoContainer>
  );
};
