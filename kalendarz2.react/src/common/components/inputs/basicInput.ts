import styled from "styled-components";

export const BasicInput = styled.input`
   &&&{
        background: white !important; 
        width:80%;
        border-radius:0.5rem;
        color:black;  
        height:1.5rem;
        margin:0.3rem 0;
        padding:0.5rem 0.2rem; 
        border:1px gray solid;
   }
   :focus-visible{
       outline:0px;
       background: white !important; 
   }
   
`;