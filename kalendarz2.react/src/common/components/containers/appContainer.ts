import styled from "styled-components"
import App from "../../../App"

interface IDarkmode {
    darkmode:boolean
  }

export const AppContainer = styled.div<IDarkmode>`
    &&&{
        text-align: center;
        font-family: 'lato';
        background-color:${(props) => props.darkmode == true? "#3e3e3e":"#AEAEAE"}; 
        height: 100vh;
    }

`