import styled from "styled-components"

interface IColor {
    darkmode:boolean;
    currentColor:string;
}

export const ColorPallet = styled.div<IColor>`
    &&&{
        width:24rem;
        height:100%;
        margin:0 auto;
        display:flex;
        align-items:center;
        justify-content:center;
        flex-wrap:wrap;
        .colorContainer{
            width:6rem;
            display:flex;
            flex-direction:column;
            align-items:center;
            height:5rem;
        }
        h2{
            font-family:'inter';
            font-size:1.4rem;
            margin-bottom:1rem;
            margin-top:2rem;
        }
        h3{
            font-family:'inter';
            font-weight:400;
            font-size:0.85rem;
        }
        div > div{
            box-sizing:border-box;
            width:2rem;
            height:2rem;
            margin:0.5rem 1rem;
            border-radius:50%;
            border-style:solid;
            border-width:2px;
        }
        div > div:hover{
            cursor: pointer;
            border:2px solid white;
        }
        .raspberry{
            background-color:#ea3ac3;
            border-color:${(props) => props.currentColor == "#ea3ac3"? "white":"black"}; 
        }
        .orange{
            background-color:#f79322;
            border-color:${(props) => props.currentColor == "#f79322"? "white":"black"}; 
        }
        .monstera{
            background-color:#0f6507;
            border-color:${(props) => props.currentColor == "#0f6507"? "white":"black"}; 
        }
        .yellow:hover{
        
        }
        .lavender{
            background-color:#ab77bd;
            border-color:${(props) => props.currentColor == "#ab77bd"? "white":"black"}; 
        }
        .default{
            background-color:#2BC598;
            border-color:${(props) => props.currentColor == "#2BC598"? "white":"black"}; 
        }
        .darkLemon{
            background-color:#bcc543;
            border-color:${(props) => props.currentColor == "#bcc543"? "white":"black"}; 
        }
        .cherry{
            background-color:#bd1a1a;
            border-color:${(props) => props.currentColor == "#bd1a1a"? "white":"black"}; 
        }
        .sky{
            background-color:#49b5c6;
            border-color:${(props) => props.currentColor == "#49b5c6"? "white":"black"}; 
        }
    }

`