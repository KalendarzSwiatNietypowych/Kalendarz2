import styled from "styled-components"

export const NavbarContainer = styled.div`
    &&&{
        padding:1rem 0;
        display:flex;
        justify-content:flex-start;
        height:4vw;
        align-items:center;
        background: rgb(55,55,55);
        background: linear-gradient(90deg, rgba(55,55,55,1) 0%, rgba(20,20,20,1) 100%);
        align-items:center;
        padding-bottom:1.4em;
     
    p{
        color:white; 
        font-size:2rem;
        font-family:'inter';
        font-weight:300;
        margin-right:auto;
    }
    a{
        text-decoration:none;
        margin:0 0vw;
        color:#2BC598;
        position:relative;
        box-sizing:border-box;
    }
    span{
        position:absolute;
        bottom:-1em;
        right:15%;
        font-family:'inter';
        font-size:0.5rem;
    }
    svg{
        color:#2BC598;
        margin:0 0.3em;
        height:1em;
        width:1em;
    }
    svg:hover{
        color:#198A67; 
        cursor: pointer; 
    }
    a:hover{
        color:#198A67; 
        cursor: pointer;
    }


    @media (min-width: 700px){
        padding:1rem;
        svg{
        color:#2BC598;
        margin:0 0.3em;
        height:2em;
        width:2em;
        }
        a{
            font-size:0.7rem;
        }
        span{
        position:absolute;
        bottom:-1em;
        right:20%;
        font-family:'inter';
        font-size:0.7rem;
    }
    }
    }
`