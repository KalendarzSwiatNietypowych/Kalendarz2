import styled from "styled-components"

export const ImportantEventsList= styled.div`
    &&&{
        background-color:#3E3E3E;
        padding: 0.58rem 0rem;   
        width:80%;
        margin:0 auto;
        overflow-y:scroll;
        height:4.9rem;
        direction:rtl;
        ul{
            
        }
        li{
            color:white;
            width:60%;
            margin-right:auto;
            margin-left:0.6em;
            text-align:left;
            direction:ltr;
            list-style-type: none;
            margin-bottom:0.8em;

        }
        ::-webkit-scrollbar {
        width: 0.5rem;
        }
        ::-webkit-scrollbar-track {
        background: #222;
        margin-bottom:0;
        }
        ::-webkit-scrollbar-thumb {
        background: lightgray; 
        }
        ::-webkit-scrollbar-thumb:hover {
        background: #ddd; 
        }
    }
`