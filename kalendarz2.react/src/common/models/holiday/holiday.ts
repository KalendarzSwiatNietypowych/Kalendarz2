export default interface holiday {
    name: string;
    date: Date;
    description: string;
  }

  export const holidayInitialState: holiday = {
    name: "",
    date: new Date(),
    description: "",
  };
    
  