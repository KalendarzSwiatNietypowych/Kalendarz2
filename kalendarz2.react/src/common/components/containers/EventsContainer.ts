import styled from "styled-components"

export const EventsContainer = styled.div`
    &&&{
            background: rgb(25,138,103);
            background: linear-gradient(180deg, rgba(25,138,103,1) 0%, rgba(43,197,152,1) 50%, rgba(25,138,103,1) 100%);
            border-radius:2rem;
            width:17%;
            margin: 2rem 82.3%;
            position:relative;
            height:6.0rem;
        h5{
            color: white;
            font-family:'inter';
            font-size:0.9rem;
            font-weight:500;
            text-align:left;
            margin-right: 3rem;
            padding:0.6rem 1rem;
        }
        h6{
            color: white;
            font-size:0.7rem;
            margin-top: 0.25rem;
            margin-left: 7%;
            text-align:left;
            direction:ltr;
        }
        
        
    .icon{
        display:flex;
        flex-direction:column;
        align-items:left;
        
    }
    .icon > svg{
        color:white;
        width:15%;
        height:15%;
        padding: 0% 80%;
        left: 20%;
        top: -10;
    } 
    .icon > svg:hover{
        cursor: pointer;
        color:darkgray;
        background-color:transparent;
    }
        
    }
`