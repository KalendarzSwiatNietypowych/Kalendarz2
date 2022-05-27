import { Checkbox } from "@mui/material";
import styled from "styled-components";

export const StyledCheckbox = styled(Checkbox)`
   &&&{
        width:4em;
        height:4em;
        border:none;
        padding:0.5rem;
   }
   svg{
       width: 4em;
       height:1.5em;
   }
   :hover{
       cursor: pointer;
   }
   
`;