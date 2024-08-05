import React from 'react'
import { useForm} from "react-hook-form"
import {Inputs, comparisonFormInputValidationSchema as ValidationSchema} from "./formValidation"
import { zodResolver } from '@hookform/resolvers/zod'
import { getProductRates } from '../../api/productComparisonApi';
import { ProductDetailsDto } from '../../types/productDetailsType';
import ProductComparisonList from './productComparisonList';

const ProductComparisonForm:React.FC = () => {
    const [productComparisons, setProductComparisons] = React.useState<ProductDetailsDto[]>([]);

    const {
        register,
        handleSubmit,
        formState: { errors },
      } = useForm<Inputs>({
        mode : "all",
        resolver: zodResolver(ValidationSchema)
      })


    const onSubmit = async (data:Inputs) => {
        const fetchedData = await getProductRates(data.yearlyUsage);
        setProductComparisons(fetchedData);
    }


    return ( 
        <>
            <p className="text-center text-gray-600 mb-6">Please enter your yearly consumption in kWh</p>
            <form className='flex flex-col items-center' onSubmit = {handleSubmit(onSubmit)}>
                <input
                    {...register("yearlyUsage")}
                    placeholder="Enter Yearly Usage"
                    className="border border-gray-300 rounded-lg p-3 w-full max-w-xs focus:outline-none focus:ring-2 focus:ring-orange-500"
                />
                {errors.yearlyUsage && <span className='w-full max-w-xs text-red-600'>{errors.yearlyUsage.message}</span>}
                <button type="submit" className="mt-4 bg-orange-600 text-white py-2 px-4 rounded-lg hover:bg-orange-700 focus:outline-none focus:ring-2 focus:ring-orange-500">Submit</button>
            </form>

            <ProductComparisonList products = {productComparisons}></ProductComparisonList>
        </>
     );
}

export default ProductComparisonForm;