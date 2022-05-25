import axios, { AxiosError } from "axios"
import { toast } from "react-toastify";

export const api = axios.create({
    baseURL: "https://localhost:7106/api/",
    withCredentials: true,
  });

  api.interceptors.request.use((request: any) => {
    var token = localStorage.getItem("userToken");
    request.headers.Authorization = `Bearer ${token}`;
    return request;
  });

  api.interceptors.response.use(
    (response) => {
      return response;
    },
    (error: AxiosError) => {
      toast.error(error.response ? error.response.data.message : error.message);
    }
  );
  