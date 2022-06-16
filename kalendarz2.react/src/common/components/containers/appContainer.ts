import styled from "styled-components"
import App from "../../../App"

interface IColor {
    darkmode:boolean
    color:string
  }

export const AppContainer = styled.div<IColor>`
    &&&{
        text-align: center;
        font-family: 'lato';
        background-color:${(props) => props.darkmode == true? "#3e3e3e":"#AEAEAE"}; 
        height: 100%;
    }

`