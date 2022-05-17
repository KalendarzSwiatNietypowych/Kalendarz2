import styled from "styled-components"

export const SidebarContainer = styled.div`
    &&&{ 
        width:11%;
        height:100vh;   
        float:left;
        background: rgb(25,138,103);
        background: linear-gradient(180deg, rgba(25,138,103,1) 0%, rgba(43,197,152,1) 50%, rgba(25,138,103,1) 100%);
    }
    .main-icon{
        margin:0;
        padding:0;
    }
    .main-icon > svg{
        width:5vw;
        height:5vw;
        margin-top:0.4rem;
        margin-bottom:12rem;
    }
    .main-icon > svg:hover{
        cursor: pointer;
        color:darkgray;
    }
    .icons{
        display:flex;
        flex-direction:column;
        align-items:center;
        
    }
    .icons > svg{
        width:20%;
        height:20%;
        padding:1vw;
    } 
    .icons > svg:hover{
        cursor: pointer;
        color:darkgray;
    }

`