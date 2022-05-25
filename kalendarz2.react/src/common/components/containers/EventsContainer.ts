import styled from "styled-components"

export const EventsContainer = styled.div`
    &&&{
        background: #3E3E3E;
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
        h2{
            font-size:2rem;
            font-weight:400;
        }
        span{
            color:#2BC598;
            font-weight:200;
        }
        span:hover{
            color:#198A67; 
            cursor: pointer;
        }
    }
`