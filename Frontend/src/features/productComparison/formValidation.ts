import { z } from "zod";



export type Inputs = {
    yearlyUsage: Number
}

const inputControls ={
    yearlyUsage : "yearlyUsage"
}


const errorMessages = {
    required: "Yearly usage is required.",
    min1: "Yearly usage cannot be zero.",
    int: "Yearly usage must be an integer.",
    nonnegative: "Yearly usage cannot be negative."
  };


export const comparisonFormInputValidationSchema = z.object({
    [inputControls.yearlyUsage] : z.coerce.number({
        required_error: errorMessages.required,
    })
    .int(errorMessages.int)
    .nonnegative(errorMessages.nonnegative)
    .min(1, { message: errorMessages.min1 })
})