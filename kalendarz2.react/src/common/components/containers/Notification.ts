import styled from "styled-components"

interface IEventColor {
    bcolor:string;
    textColor:string;
}

export const Notification = styled.div<IEventColor>`
    &&&{
        width:20rem !important;
        margin:2rem 1rem;
        border-radius:1rem;
        box-shadow:
        5.5px 9.1px 11px rgba(0, 0, 0, 0.331),
        21px 35px 92px rgba(0, 0, 0, 0.22)
        ;
        background-color:${(props) => props.bcolor}; 
        min-height:18rem;
        float:left;
        flex-shrink:0;
        margin-bottom:2rem;
        min-height:8rem;
        h2{
            color: ${(props) => props.textColor || "white"};
            font-family:'inter';
            font-size:1rem;
            font-weight:900;
            letter-spacing:0.1rem;
            text-align:left;
            padding:1rem;
        }
        h3{
            color: ${(props) => props.textColor || "white"};
            font-family:'inter';
            font-size:1rem;
            font-weight:400;
            text-align:left;
            padding:0.5rem 2rem;
            letter-spacing:0;
    
        }
        .eventTitle > svg{
            display:block;
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
        @media (min-width: 1200px){
            width:25rem;
    }
}
`