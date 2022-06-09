import styled from "styled-components"

export const Event = styled.div`
    &&&{
        width:70%;
        margin:3rem auto;
        border-radius:2rem;
        background-color:#2BC598;
        background:linear-gradient(45deg, #2BC598 0%, #09A376 100%);

        h2{
            color: black;
            font-family:'inter';
            font-size:1rem;
            font-weight:900;
            letter-spacing:0.1rem;
            text-align:left;
            padding:1rem;
        }
        h3{
            color: white;
            font-family:'inter';
            font-size:0.8rem;
            font-weight:400;
            text-align:left;
            padding:0.5rem 1rem;
            padding-right:0;
            letter-spacing:0.05rem;
        }
        .eventTitle > svg{
            display:none;
            padding:0;
            margin-right:1rem;
            color:black;
           
        }
        .eventTitle{
            display:flex;
            align-items:center;
            justify-content:space-between;
        }
        .eventLocation > svg{
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
        .eventButtons > svg:hover{
            cursor: pointer;
            color:darkorange;
        }
        @media (min-width: 900px){
            .eventTitle > svg{
                display:block;
            }
    }
}
`