import styled from "styled-components";

export const ColorInput = styled.input`
   &&&{
        background:transparent;
        border-radius:50%; 
        width:4em;
        height:4em;
        border:none;
        padding:0.5rem;
   }
   :focus-visible{
       outline:0px;
       background: white !important; 
   }
   :hover{
       cursor: pointer;
   } 
`