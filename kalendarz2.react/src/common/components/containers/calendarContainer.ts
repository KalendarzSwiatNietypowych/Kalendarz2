import styled from "styled-components";

interface IColor {
  darkmode:boolean
  color:string
}

export const CalendarContainer = styled.div<IColor>`
  &&& {
    width: 100%;
    overflow:hidden;
    margin: 0 auto;
    background: ${(props) => props.darkmode == true? "rgb(55,55,55)": "rgb(239,239,239)"};
    background:${(props) => props.darkmode == true? "linear-gradient(90deg, rgba(55,55,55,1) 0%, rgba(20,20,20,1) 100%)": "linear-gradient(180deg, rgba(239,239,239,1) 0%, rgba(212,212,212,1) 100%)"}; 
    padding-top:1rem;
    button{
      margin:0;
    }
    td {
      border: 0px rgba(43, 197, 152, 1) solid;
      border-collapse: collapse;
      border-spacing: 0;
    }
    [role="grid"] {
      border: none;
    }
    th {
      border: none;
    }
    table {
      border-collapse: collapse;
    }
    .fc-daygrid-day-frame {
      margin-bottom: 0.6rem;
      color:${(props) => props.darkmode == true? "white":"black"}; 
      max-height: 5px;
    }
    .fc-button {
      color:${(props) => props.darkmode == true? "white":"black"}; 
      background: ${(props) =>props.color};
      margin:0 0.2rem;
    }
    .fc-header-toolbar{
      margin:0;
    }
    .fc-prev-button,
    .fc-next-button,
    .fc-today-button {
      margin-bottom: 1rem;
    }
    .fc-dayGridMonth-button, .fc-timeGridWeek-button, .fc-timeGridDay-button{
      width:5em;
    }
    .fc-header-toolbar > div{
      display:flex;
      flex-direction:column;
      align-items:center;
    }
    span,
    .fc-timegrid-slot-label-cushion {
      color:${(props) => props.darkmode == true? "white":"black"}; 
    }
    .fc-daygrid-day-top{
      justify-content:center;
    }
    .fc-daygrid-event{
      white-space:normal;
    }
    .fc-toolbar-title {
      font-family: "inter";
      color:${(props) => props.darkmode == true? "white":"black"}; 
      font-weight: 200;
    }
    .fc-col-header-cell {
      font-family: "inter";
      color:${(props) => props.darkmode == true? "white":"black"}; 
      font-weight: 200;
      padding: 1rem 0;
    }
    .fc-col-header {
      overflow: hidden;
      margin: 1rem 0;
      background-color:${(props) => props.darkmode == true? "#3e3e3e":"#AEAEAE"}; 
      border-radius: 1rem;
    }
    .fc-scrollgrid-section-header div {
      overflow: hidden !important;
    }
    .fc {
      margin: 0 1rem;
    }
    .fc-cell-shaded {
      background-color: transparent;
    }
    .fc-h-event {
      background-color: #ffe17d;
    }
    .fc-h-event i {
      font-family: "inter";
      font-size: 0.7rem;
      font-weight: 600;
    }
    .fc-scroller::-webkit-scrollbar {
        width: 0.5rem !important;
    }
    .fc-scroller::-webkit-scrollbar-track {
        border-top-left-radius:3rem !important;
        border-top-right-radius:3rem !important;
        background:#3E3E3E;
        margin:0.5rem 0;
        margin-bottom:0;
    }
    .fc-scroller::-webkit-scrollbar-thumb {
        background: white !important; 
        border-radius: 10px;
     }
     .fc-scroller::-webkit-scrollbar-thumb:hover {
        background: #ddd !important; 
    }
    @media (min-width: 700px){
      float:left;
      width:70%;
      .fc-header-toolbar > div{
      flex-direction:row;
    }
    }
    tr{
      height:3rem;
    }
  }
`;