import styled from "styled-components";

export const SubmitButton = styled.button`
   &&&{
        width:20em;
        border-radius:10rem; 
        height:2rem;
        margin:0.3rem;
        margin-bottom:1rem;
        padding:0.5rem; 
        border:none;
        color:black;
        font-family:'inter';
        font-weight:800;
        background: rgb(25,138,103);
        background: linear-gradient(180deg, rgba(25,138,103,1) 0%, rgba(43,197,152,1) 50%, rgba(25,138,103,1) 100%);
        :hover{
        cursor: pointer;
        color:#666;
   }
   }
`;