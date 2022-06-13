import { rgbToHex } from "@mui/material"
import styled from "styled-components"

interface IColor {
    darkmode:boolean
    color:string
}
export const NavbarContainer = styled.div<IColor>`
    &&&{
        padding:1rem 0;
        display:flex;
        justify-content:flex-start;
        height:6.4vh;
        align-items:center;
        background: ${(props) => props.darkmode == true? "rgb(55,55,55)": "rgb(239,239,239)"};
        background:${(props) => props.darkmode == true? "linear-gradient(90deg, rgba(55,55,55,1) 0%, rgba(20,20,20,1) 100%)": "linear-gradient(180deg, rgba(239,239,239,1) 0%, rgba(212,212,212,1) 100%)"}; 
        align-items:center;
        padding-bottom:1.4em;
     
    p{
        color:${(props) => props.darkmode == true? "white":"black"}; 
        font-size:2rem;
        font-family:'inter';
        font-weight:300;
        margin-right:auto;
    }
    a{
        text-decoration:none;
        margin:0 0vw;
        color:${(props) => props.color};
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
        color:${(props) => props.color};
        margin:0 0.3em;
        height:1em;
        width:1em;
    }
    svg:hover{
        color: ${(props) => props.darkmode == true? "white": "black"};
        cursor: pointer; 
    }
    a:hover{
        color: ${(props) => props.darkmode == true? "white": "black"};
        cursor: pointer;
    }


    @media (min-width: 700px){
        padding:1rem;
        svg{
        color:${(props) => props.color};
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