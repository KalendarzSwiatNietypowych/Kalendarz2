export default interface updateEvent {
    authorId: number;
    id:number;
    title: string;
    description: string;
    location:string;
    participantsEmails:string[]|null;
    startEvent: Date;
    endEvent: Date;
    color:string;
    isRecurring:boolean
    isDeleted:boolean
  }