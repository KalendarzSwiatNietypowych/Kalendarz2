import styled from "styled-components"
import App from "../../../App"

interface IColor {
    darkmode:boolean;
    currentColor:number;
  }

export const ColorPallet = styled.div<IColor>`
    &&&{
        width:16rem;
        height:100%;
        margin:0 auto;
        display:flex;
        align-items:center;
        justify-content:center;
        flex-wrap:wrap;
        h2{
            font-family:'inter';
            font-size:1.4rem;
            margin-bottom:1rem;
            margin-top:2rem;
        }
        div{
            box-sizing:border-box;
            width:2rem;
            height:2rem;
            margin:0.5rem 1rem;
            border-radius:50%;
            border-style:solid;
            border-width:2px;
        }
        div:hover{
            cursor: pointer;
            border:2px solid white;
        }
        .red{
            background-color:red;
            border-color:${(props) => props.currentColor == 0? "white":"black"}; 
        }
        .orange{
            background-color:orange;
            border-color:${(props) => props.currentColor == 1? "white":"black"}; 
        }
        .yellow{
            background-color:yellow;
            border-color:${(props) => props.currentColor == 2? "white":"black"}; 
        }
        .yellow:hover{
        
        }
        .green{
            background-color:green;
            border-color:${(props) => props.currentColor == 3? "white":"black"}; 
        }
        .default{
            background-color:#2BC598;
            border-color:${(props) => props.currentColor == 4? "white":"black"}; 
        }
        .blue{
            background-color:blue;
            border-color:${(props) => props.currentColor == 5? "white":"black"}; 
        }
        .darkblue{
            background-color:darkblue;
            border-color:${(props) => props.currentColor == 6? "white":"black"}; 
        }
        .violet{
            background-color:violet;
            border-color:${(props) => props.currentColor == 7? "white":"black"}; 
        }
    }

`