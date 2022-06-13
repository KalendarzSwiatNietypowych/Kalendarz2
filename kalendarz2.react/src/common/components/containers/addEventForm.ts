import styled from "styled-components"

interface IColor {
    darkmode:boolean
    color:string
}

export const AddEventForm = styled.div<IColor>`
    &&&{
        width:100%;
        margin:0 auto; 
        height:100%;
        margin-top:4rem;
        min-width:15rem;
        display:flex;
        flex-direction:column;
        align-items:center;
        justify-content:space-evenly;
        color:${(props) => props.darkmode == true? "white":"black"}; 
        float:left;
        p{
        font-size:2.2rem;
        font-family:'inter';
        margin:1rem;
        padding-bottom:0.3rem;
        border-bottom:1px solid #00FF99;
        }
        h2{
        font-family:'inter';
        font-size:1rem;
        font-weight:300;
        }
    }

`