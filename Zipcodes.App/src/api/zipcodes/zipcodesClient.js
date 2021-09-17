import baseApiClient from "../baseApiClient";

export const getPostalRecords = () => {
    return baseApiClient.get('postal/records');
}