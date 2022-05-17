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
        li{
            text-align:left;
            width:50%;
            direction:ltr;
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