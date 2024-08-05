import React, { Component } from 'react'
import ProductComparisonForm from '../productComparison/productComparisonForm';

const MainPage: React.FC = () => {
    return (
        <div className="bg-orange-50 p-8 rounded-xl drop-shadow-2xl shadow-lg w-full max-w-md">
            <p className='text-2xl font-bold text-center text-orange-600 mb-4'>Electricity Rate Comparison</p>
            <ProductComparisonForm></ProductComparisonForm>
        </div>
    );
}

export default MainPage;