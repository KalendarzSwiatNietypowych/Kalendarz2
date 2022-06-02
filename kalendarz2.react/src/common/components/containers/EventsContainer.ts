import styled from "styled-components"

interface IDarkmode {
    darkmode:boolean
  }

export const EventsContainer = styled.div<IDarkmode>`
    &&&{
        float:right;
        width:100%;
        height:40vh;
        background-color:${(props) => props.darkmode == true? "#3e3e3e":"#AEAEAE"}; 
        overflow-y:auto;
        font-family:'inter';
        ul{
            display:flex;
            align-items:center;
            flex-direction:column;
        }
        li{
            margin:0 auto;
            list-style:none;
        }
        h1{
            font-size:2rem;
            font-weight:400;
            color:${(props) => props.darkmode == true? "white":"black"}; 
            letter-spacing:0.3rem;
            text-decoration:underline;
            text-underline-offset:0.7rem;
            margin-top:0.6rem;
        }
        span{
            color:${(props) => props.darkmode == true? "#2BC598":"#198A67"}; 
            
            font-weight:200;
        }
        span:hover{
            color:${(props) => props.darkmode == true? "#198A67":"#2BC598"}; 
            
            cursor: pointer;
        }
        @media (min-width: 700px){
            width:30%;
            height:90vh;
        }
    }
`