export default interface event {
    authorId: number;
    title: string;
    description: string;
    location:string;
    participantsEmails:string[]|null;
    startDate: Date;
    endDate: Date;
    color:number;
    isRecurring:boolean
    
  }

  export const initialState: event = {
    authorId: -1,
    title: "",
    description: "",
    location:"",
    participantsEmails:[],
    startDate:  new Date(),
    endDate: new Date(),
    color: 1,
    isRecurring:false
  };
    