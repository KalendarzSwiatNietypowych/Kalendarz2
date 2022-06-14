export default interface changePassword {
    userId: number;
    oldPassword:string;
    password: string;
  }

  export const initialState: changePassword = {
    userId: 0,
    oldPassword:"",
    password: ""
  };
  

  