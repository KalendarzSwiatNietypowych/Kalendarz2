import styled from "styled-components"

interface IColor {
    darkmode:boolean
    color:string
  }
  
export const EventsContainer = styled.div<IColor>`
    &&&{
        float:right;
        width:100%;
        height:70vh;
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
            margin:0 0.2rem;
            line-height:3rem;
            font-size:2rem;
            font-weight:400;
            color:${(props) => props.darkmode == true? "white":"black"}; 
            letter-spacing:0.3rem;
            text-decoration:underline;
            text-underline-offset:0.7rem;
            margin-top:0.6rem;
            margin-bottom:0.5rem;
        }
        h4{
            
            font-weight:300;
            font-size:1.3rem;
            margin-bottom:1rem;
        }
        h2{
            font-weight:400;
            font-size:1.4rem;
        }
        span{
            color:${(props) => props.color}; 
            
            font-weight:400;
        }
        span:hover{
            color:${(props) => props.darkmode == true? "white":"black"}; 
            
            cursor: pointer;
        }
        @media (min-width: 1200px){
            width:30%;
            height:90.3vh;
        }
    }
`