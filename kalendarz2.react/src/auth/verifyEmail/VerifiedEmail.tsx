import { InfoContainer } from "../../common/components/containers/infoContainer";
import { useAppSelector } from "../../common/store/rootReducer";
import { SelectUser } from "../slice";

export const VerifiedEmail = () => {
  const isDarkmode = useAppSelector((state) => SelectUser(state)).isDarkmode;
  return (
    <InfoContainer darkmode={isDarkmode}>
      <p>Your email has been verified,</p>
      <p>be welcome to login and use our calendar!</p>
    </InfoContainer>
  );
};
