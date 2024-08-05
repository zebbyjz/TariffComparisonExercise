import clientSettings from "../clientSettings.json"

let apiSettings = clientSettings;
const beApiUrl = apiSettings.beApiUrl;

export const productComparisonApiUrl = {
    get : beApiUrl.concat('/Tariff')
}