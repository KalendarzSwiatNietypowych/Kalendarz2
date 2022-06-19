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
        box-shadow:
            3.4px 5.7px 4.9px rgba(0, 0, 0, 0.301),
            8.1px 13.5px 21.7px rgba(0, 0, 0, 0.339),
            21px 35px 92px rgba(0, 0, 0, 0.22)
        ;
        background-color:${(props) => props.bcolor}; 
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
            color: ${(props) => props.textColor};
        }
        .eventLocation{
            display:flex;
            align-items:center;
        }
        .eventButtons{
            display:flex;
            align-items:center;
            color: ${(props) => props.textColor};
            justify-content:flex-end;
            margin-right:1em;
            padding-bottom:0.5em;
        }
        .eventButtons > svg{    
            padding:0.3rem;
            margin-left:0rem;     
        }
        .eventButtons > svg:hover{
            cursor: pointer;
            color: ${(props) => props.textColor == "white"? "#a7a7a7":"#676767"};
            transform:scale(1.4);     
        }
}
`