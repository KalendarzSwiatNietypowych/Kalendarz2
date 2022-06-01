export default interface event {
  id:number;
  authorId: number;
  title: string;
  description: string;
  location:string;
  participantsEmails:string[]|null;
  startEvent: Date;
  endEvent: Date;
  color:string;
  isRecurring:boolean
}

export const initialState: event = {
  id:-1,
  authorId: -1,
  title: "",
  description: "",
  location:"",
  participantsEmails:[],
  startEvent:  new Date(),
  endEvent: new Date(),
  color: "#0000ff",
  isRecurring:false
};
    