export default interface holiday {
    id: number;
    name: string;
    startDate: Date;
    endDate: Date;
    description: string;
  }

  export const holidayInitialState: holiday = {
    id: -1,
    name: "",
    startDate: new Date(),
    endDate: new Date(),
    description: "",
  };
    
  