import styled from "styled-components"

interface IColor {
    darkmode:boolean
    color:string
}

export const HolidayContainer = styled.div<IColor>`
    &&&{
        background: ${(props) =>props.color};
        border-radius:2rem;
        border: 1px black solid;
        margin: 1rem;
        position:relative;
        box-sizing:border-box;
        min-height:13.6vh;
        div{
            display:flex;
            align-items:flex-start;
            flex-direction:column;
            
        }
        .description{
            width:55%;
        }
        h1{
            font-family:'inter';
            font-size:1rem;
            font-weight:500;
            text-align:left;
            margin-left:2rem;
            padding:0.3rem 0;
        }
        h2{
            font-family:'inter';
            font-size:1.1rem;
            font-weight:700;
            text-align:left;
            margin-left:2rem;
            padding:0.3rem 0;
            
        
        }
        h3{
            font-family:'inter';
            font-size:0.8rem;
            font-weight:500;
            text-align:left;
            padding:0.3rem 0;
            margin-left:2rem;
        }
        img{
            width:6rem;
            position:absolute;
            bottom:0;
            right:5vw;
            background-color:transparent;
            transform:rotate(-5deg);
        }
        @media (min-width: 1200px){
            div{
            display:flex;
            align-items:flex-start;
            flex-direction:row;
            
            }
            .description{
                width:60%;
            }
            h1{
                font-family:'inter';
                font-size:1.5rem;
                font-weight:500;
                text-align:left;
                margin-left:2rem;
                padding:0.3rem 0;
            }
            h2{
                font-family:'inter';
                font-size:1.7rem;
                font-weight:700;
                text-align:left;
                margin-left:1rem;
                padding:0.3rem 0;
            }
            h3{
                font-family:'inter';
                font-size:1rem;
                font-weight:500;
                text-align:left;
                padding:0.3rem 0;
                margin-left:2rem;
            }
            img{
                width:8rem;
            }
            }
    }
`