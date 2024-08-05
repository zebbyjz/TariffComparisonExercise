import axios from 'axios';
import { productComparisonApiUrl } from './config';



export const getProductRates = async (yearlyUsage: Number) => {
  const response = await axios.get(productComparisonApiUrl.get, {
      params: {
          yearlyUsage : yearlyUsage
      }
  });
  return response.data;
};