import styled from "styled-components"

export const NavbarContainer = styled.div`
    &&&{
        background: #5dacbd; 
        padding:1rem;
        display:flex;
        justify-content:flex-start;
        max-height:2rem;
        align-items:center;

    }
    p{
        color:black; 
        margin-right:auto;
        font-size:1.5rem;
    }
    a{
        text-decoration:none;
        font-size:1.3rem;
        margin:0 0.4rem;
        color:black;
    }
    a:hover{
        color:#24527a; 
    }
   
`