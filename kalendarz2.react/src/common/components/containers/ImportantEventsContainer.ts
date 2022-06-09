import styled from "styled-components"

export const ImportantEventsContainer = styled.div`
    &&&{
        background: rgb(25,138,103);
        background:linear-gradient(90deg, #2BC598 0%, #09A376 50%, #2BC598 100%);
        border-radius:2rem;
        border: 1px black solid;
        margin: 1rem;
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
        @media (min-width: 700px){

        }
    }
`