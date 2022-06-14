export default interface user {
    id: number;
    firstName: string;
    lastName: string;
    email:string;
    token: string;
    color:string;
    isDarkmode:boolean
  }
  
  export const initialState: user = {
    id: 0,
    firstName: "",
    email:"",
    lastName: "",
    token: "",
    color:"#2BC598",
    isDarkmode:true
  };