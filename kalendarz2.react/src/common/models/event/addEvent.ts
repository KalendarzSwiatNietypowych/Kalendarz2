export default interface addEvent {
    authorId:number;
    title: string;
    description: string;
    location:string;
    participantsEmails:string[]|null;
    startEvent: Date;
    endEvent: Date;
    color:number;
    isRecurring:boolean
  }