import axios from "axios"
import config from "../assets/config";

const baseApiClient = axios.create({
    baseURL: config.apiUrl,
});

baseApiClient.interceptors.response.use((response) => {
    // Return directly the data no need to check status code here
    // This help not having to do response.data everytime.
    return response.data;
}, (error) => {

    return Promise.reject(error);
});

export default baseApiClient