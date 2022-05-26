export default interface event {
  authorId: number;
  title: string;
  description: string;
  location:string;
  participantsEmails:string[]|null;
  startEvent: Date;
  endEvent: Date;
  color:number;
  isRecurring:boolean
  
}

export const initialState: event = {
  authorId: -1,
  title: "",
  description: "",
  location:"",
  participantsEmails:[],
  startEvent:  new Date(),
  endEvent: new Date(),
  color: 1,
  isRecurring:false
};
    