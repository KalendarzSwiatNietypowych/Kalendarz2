import styled from "styled-components";

interface IColor {
   darkmode:boolean
   color:string
 }
 

export const SubmitButton = styled.button<IColor>`
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
        background: ${(props) =>props.color};
        :hover{
        cursor: pointer;
        color:#666;
   }
   }
`;