import styled from "styled-components"

interface IEventColor {
    bcolor:string;
    textColor:string;
}

export const Event = styled.div<IEventColor>`
    &&&{
        width:70%;
        margin:3rem auto;
        border-radius:1rem;
        border:2px solid black;
        background-color:${(props) => props.bcolor}; 
        //background-color:#2BC598;
        //background:linear-gradient(45deg, #2BC598 0%, #09A376 100%);
        h2{
            color: ${(props) => props.textColor};
            font-family:'inter';
            font-size:1rem;
            font-weight:900;
            letter-spacing:0.1rem;
            text-align:left;
            padding:1rem;
        }
        h3{
            color: ${(props) => props.textColor};
            font-family:'inter';
            font-size:1rem;
            font-weight:400;
            text-align:left;
            padding:0.5rem 2rem;
            letter-spacing:0;
    
        }
        .eventTitle > svg{
            display:none;
            padding:0;
            margin-right:0.5rem;
            color:black;
            background-color:white;
            padding:0.3rem;
            border-radius:50%;
        }
        .eventTitle{
            display:flex;
            align-items:center;
            justify-content:space-between;
        }
        h3 > svg{
            padding:0;
            margin-right:1rem;
            color:orange;
        }
        .eventLocation{
            display:flex;
            align-items:center;
        }
        .eventButtons{
            display:flex;
            align-items:center;
            color:orange;
            justify-content:flex-end;
            margin-right:1em;
            padding-bottom:0.5em;
        }
        .eventButtons > svg{
            background-color:white;
            padding:0.3rem;
            border-radius:50%;
            margin-left:0.4rem;
            border:1px black solid;
        }
        .eventButtons > svg:hover{
            cursor: pointer;
            color:darkorange;
            background-color:#ddd;
        }
        @media (min-width: 900px){
            .eventTitle > svg{
                display:block;
            }
    }
}
`