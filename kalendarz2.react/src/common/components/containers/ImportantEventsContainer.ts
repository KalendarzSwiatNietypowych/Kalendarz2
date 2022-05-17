import styled from "styled-components"

export const ImportantEventsContainer = styled.div`
    &&&{
        background: rgb(25,138,103);
        background: linear-gradient(180deg, rgba(25,138,103,1) 0%, rgba(43,197,152,1) 50%, rgba(25,138,103,1) 100%);
        border-radius:2rem;
        margin: 1rem 1rem;
        position:relative;
        height:8.2rem;
        h4{
            font-family:'inter';
            font-size:1.3rem;
            font-weight:500;
            text-align:left;
            margin-left:3rem;
            padding:0.3rem 0;
        }
        img{
            width:8rem;
            position:absolute;
            bottom:0;
            right:5vw;
            background-color:transparent;
            transform:rotate(-5deg);
        }
    }
`