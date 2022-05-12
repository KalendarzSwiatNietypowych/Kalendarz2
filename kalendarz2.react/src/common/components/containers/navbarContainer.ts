import styled from "styled-components"

export const NavbarContainer = styled.div`
    &&&{
        padding:1rem;
        display:flex;
        justify-content:flex-start;
        
        height:4vw;
        align-items:center;
        background: rgb(55,55,55);
        background: linear-gradient(90deg, rgba(55,55,55,1) 0%, rgba(20,20,20,1) 100%);
    p{
        color:white; 
        margin-right:auto;
        font-size:2.8vw;
        font-family:'inter';
        font-weight:300;
        padding:0.5vw;
        
    }
    a{
        text-decoration:none;
        font-size:1.4vw;
        margin:0 0vw;
        color:#2BC598;
        display:flex;
        align-items:center;
        font-family:'inter';
    }
    a > svg{
       margin:0;
       height:1.5vw;
       width:1.5vw;

    }
    a:hover{
        color:#198A67; 
        cursor: pointer;
    }
    }
`