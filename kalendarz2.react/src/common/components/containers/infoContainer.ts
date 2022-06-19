import styled from "styled-components"

interface IColor {
    darkmode:boolean
}

export const InfoContainer = styled.div<IColor>`
     &&&{
        padding:1rem 0;
        align-items:center;
        padding-bottom:1,4em;
        vertical-align:middle;
        position:absolute; top:30%;
        width:100%;
        p{
            margin-right: auto;
            color:${(props) => props.darkmode == true? "white":"black"}; 
            font-size:2rem;
            font-family:'inter';
            font-weight:300;
        }
    }
`