import event from "./event";

export default interface events{
    events:event[];
}

export const initialState: events = {
    events:[],
}