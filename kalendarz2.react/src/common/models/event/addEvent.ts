export default interface addEvent {
    authorId:number;
    title: string;
    description: string;
    location:string;
    participantsEmails:string[]|null;
    startDate: Date;
    endDate: Date;
    color:number;
    isRecurring:boolean
  }