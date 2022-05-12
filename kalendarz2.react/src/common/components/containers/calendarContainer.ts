import styled from "styled-components"

export const CalendarContainer = styled.div`
    &&&{
        width:70vw;
        margin:0 auto;
        background: rgb(55,55,55);
        background: linear-gradient(90deg, rgba(55,55,55,1) 0%, rgba(20,20,20,1) 100%);
        float:left;
        td{
           border:1px rgba(43,197,152,1) solid;
           border-collapse:collapse;
           border-spacing:0;
        }
        [role=grid]{
           border:none;
            
        }
        th{
            border:none;
        }
        table{
            border-collapse:collapse;
        }
        .fc-daygrid-day-frame{
            margin-bottom:0.6rem;
            background-color:#3E3E3E;
            color:white;
            max-height:5px;
    
        }
        .fc-button{
            background: rgb(25,138,103);
            background: linear-gradient(180deg, rgba(25,138,103,1) 0%, rgba(43,197,152,1) 50%, rgba(25,138,103,1) 100%);

        }
        .fc-prev-button, .fc-next-button{
            margin-bottom:1rem;
        }
        .fc-toolbar-title{
            font-family:'inter';
            margin-bottom:1rem;
            color:white;
            font-weight:200;
        }
        .fc-col-header-cell{
            font-family:'inter';
            color:white;
            font-weight:200;
            padding:1rem 0;
            
        }
        .fc-col-header{
            margin:1rem 0;
            background-color: #3E3E3E;
            border-radius:1rem;
        }
        .fc{
            margin: 0 1rem;
        }
        .fc-h-event{
            background-color:#FFE17D;
            
        }
        .fc-h-event i{
            color:black;
            font-family:'inter';
            font-size:0.7rem;
            font-weight:600;
        }

    }
`