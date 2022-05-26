import styled from "styled-components"

export const EventsContainer = styled.div`
    &&&{
        float:right;
        width:100%;
        height:40vh;
        background: #3E3E3E;
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
            color:white;
            letter-spacing:0.3rem;
            text-decoration:underline;
            text-underline-offset:0.7rem;
            margin-top:0.6rem;
        }
        span{
            color:#2BC598;
            font-weight:200;
        }
        span:hover{
            color:#198A67; 
            cursor: pointer;
        }
        @media (min-width: 700px){
            width:30%;
            height:90vh;
        }
    }
`