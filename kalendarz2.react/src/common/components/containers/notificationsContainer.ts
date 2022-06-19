import styled from "styled-components"

interface IColor {
    darkmode:boolean
    color:string
  }

export const NotificationsContainer = styled.div<IColor>`
    &&&{
        float:right;
        width:100%;
        background-color:${(props) => props.darkmode == true? "#3e3e3e":"lightgray"}; 
        overflow-y:auto;
        font-family:'inter';
        display:flex;
        flex-direction:column;
        justify-content:flex-start;
        align-items:center;
        .bold{
            font-weight:900 !important;
            text-decoration:underline;
        }
        .notifications-group{
            display:flex;
            flex-direction:column;
            align-items:center;
            width:98vw;
            flex-shrink:0;
            
        }
        .notifications{
            display:flex;
            overflow-x:auto;
            height:100%;
            width:100%;
            ::-webkit-scrollbar {
            width: 20px !important;
            
            }
          
          /* Track */
            ::-webkit-scrollbar-track {
            background: transparent;
            }
          
          /* Handle */
            ::-webkit-scrollbar-thumb {
            background: white;
            border-radius:1rem;
            }
          
          /* Handle on hover */
            ::-webkit-scrollbar-thumb:hover {
            background: lightgray;
            }
            }
        ul{
            display:flex;
            align-items:center;
            flex-direction:column;
        }
        li{
            margin:0 auto;
            list-style:none;
        }
        h1{
            margin:1rem;
            line-height:3rem;
            font-size:2rem;
            font-weight:400;
            color:${(props) => props.darkmode == true? "white":"black"}; 
            letter-spacing:0.3rem;
            text-decoration:underline;
            text-underline-offset:0.7rem;
        }
        h4{
            font-weight:300;
            font-size:1.3rem;
            margin-bottom:1rem;
        }
        h2{
            margin:0rem 0;
            font-weight:400;
            font-size:1.4rem;
        }
        span{
            color:${(props) => props.color}; 
            font-weight:400;
        }
        span:hover{
            color:${(props) => props.darkmode == true? "white":"black"}; 
            cursor: pointer;
        }
        @media (min-width: 1200px){
            width:100%; 
        }
    }
`