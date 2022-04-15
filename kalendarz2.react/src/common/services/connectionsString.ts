import axios from "axios"

export const api = axios.create({
    baseURL: "https://localhost:2137/api/",
    withCredentials: true,
  });