import { InfoContainer } from "../../common/components/containers/infoContainer";
import { useAppSelector } from "../../common/store/rootReducer";
import { SelectUser } from "../slice";

export const SendVerificationEmail = () => {
  const isDarkmode = useAppSelector((state) => SelectUser(state)).isDarkmode;
  return (
    <InfoContainer darkmode={isDarkmode}>
      <p>Hi, check your email in order to</p>
      <p>authenticate your account!</p>
    </InfoContainer>
  );
};
