import styled from "styled-components";

export const CalendarContainer = styled.div`
  &&& {
    width: 100%;
    margin: 0 auto;
    background: rgb(55, 55, 55);
    background: linear-gradient(
      90deg,
      rgba(55, 55, 55, 1) 0%,
      rgba(20, 20, 20, 1) 100%
    );
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

      color: white;
      max-height: 5px;
    }
    .fc-button {
      background: rgb(25, 138, 103);
      background: linear-gradient(
        180deg,
        rgba(25, 138, 103, 1) 0%,
        rgba(43, 197, 152, 1) 50%,
        rgba(25, 138, 103, 1) 100%
      );
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
      color: white;
    }
    .fc-daygrid-day-top{
      justify-content:center;
    }
    .fc-daygrid-event{
      white-space:normal;
    }
    .fc-toolbar-title {
      font-family: "inter";
      color: white;
      font-weight: 200;
    }
    .fc-col-header-cell {
      font-family: "inter";
      color: white;
      font-weight: 200;
      padding: 1rem 0;
    }
    .fc-col-header {
      overflow: hidden;
      margin: 1rem 0;
      background-color: #3e3e3e;
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
      color: black;
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
      width:70vw;
      .fc-header-toolbar > div{
      flex-direction:row;
    }
    }
    tr{
      height:3rem;
    }
  }
`;
