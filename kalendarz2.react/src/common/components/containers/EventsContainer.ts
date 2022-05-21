import styled from "styled-components"

export const EventsContainer = styled.div`
    &&&{
            background: rgb(25,138,103);
            background: linear-gradient(180deg, rgba(25,138,103,1) 0%, rgba(43,197,152,1) 50%, rgba(25,138,103,1) 100%);
            border-radius:2rem;
            width:17%;
            margin: 1rem 82.3%;
            position:relative;
            height:6.0rem;
        h5{
            color: white;
            font-family:'inter';
            font-size:0.9rem;
            font-weight:500;
            text-align:left;
            margin-right: 3rem;
            padding:0.9rem 1rem;
        }
        h6{
            color: white;
            font-size:0.7rem;
            margin-top: 0.25rem;
            margin-left: 7%;
            text-align:left;
            direction:ltr;
        }
        img{
            width:1.5rem;
            position:relative;
            left: 38%;
            top: 10%;
            //bottom:5;
            //right:5;
            //margin: 1% 5%;
            background-color:transparent;
            transform:rotate(-5deg);
        }
    }
`