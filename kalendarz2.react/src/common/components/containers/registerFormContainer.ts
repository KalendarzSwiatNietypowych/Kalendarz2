import styled from "styled-components"

interface IColor {
    darkmode:boolean
    color:string
}

export const RegisterFormContainer = styled.div<IColor>`
    &&&{
        width:100%;
        margin:0 auto; 
        border-radius:1rem;
        height:100%;
        background-color:${(props) => props.darkmode == true? "#3e3e3e":"#AEAEAE"}; 
        margin-top:4rem;
        min-width:15rem;
        display:flex;
        flex-direction:column;
        align-items:center;
        border:none;
        color:${(props) => props.darkmode == true? "white":"black"}; 
        }
    p{
        font-size:1.2rem;
        font-family:'inter';
        margin:1rem;
        padding-bottom:0.3rem;
        border-bottom:1px solid;
        border-color:${(props) => props.color}; 
    }
    h2{
        font-family:'inter';
        font-size:1rem;
        font-weight:300;
    }
`