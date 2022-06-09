import holiday from "./holiday";

export default interface holidays{
    holidays:holiday[];
}

export const initialState: holidays = {
    holidays:[],
}