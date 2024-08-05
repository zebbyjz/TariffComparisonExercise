import React, { Component } from 'react'
import { ProductDetailsDto } from '../../types/productDetailsType'



interface ProductComparisonListProps {
    products: ProductDetailsDto[];
}

const ProductComparisonList:React.FC<ProductComparisonListProps> = ({products}) => {
    const emptyRender = () => {
        return (<></>)
    }

    const renderListView = () => {
        // For general currency formatting in euros.
        const euroFormatter = new Intl.NumberFormat('de-DE', {
            style: 'currency',
            currency: 'EUR'
        });

        const formatCentsAsEuros = (cents: number): string => {
            //For formatting Additional kWh cost, since it is in cents
            const euroFormatter = new Intl.NumberFormat('de-DE', {
                style: 'currency',
                currency: 'EUR',
                minimumFractionDigits: 2,
                maximumFractionDigits: 2
            });
        
            
            const euros = cents / 100;
            return euroFormatter.format(euros);
        };
    
        return (
            products.map(product => (
                <div className="bg-orange-500 p-8 rounded-xl w-full mb-6">
                    <p className='text-2xl font-bold text-white'>{product.name}</p>
                    <p className='text-md text-white'>Base Cost: {euroFormatter.format(product.baseCost)}</p>
                    <p className='text-md text-white'>Additional kWh Cost: {formatCentsAsEuros(product.additionalKwhCost)}</p>
                    <div className="mb-6"></div>
                    <p className='text-lg font-bold text-white text-right'>Yearly Cost: {euroFormatter.format(product.yearlyCost)}</p>
                </div>
            ))
        );
    }
    


    return ( 
        <div className="mt-6">
            {products.length > 0 ? renderListView() : null}
        </div>
     )
}

export default ProductComparisonList ;