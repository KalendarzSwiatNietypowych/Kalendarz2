export default interface updateSettings {
    userId: number;
    firstName: string;
    lastName: string;
    email:string;
    color:string;
    isDarkmode:boolean
  }
  
  export const initialState: updateSettings = {
    userId: 0,
    firstName: "",
    email:"",
    lastName: "",
    color:"#2BC598",
    isDarkmode:false
  };