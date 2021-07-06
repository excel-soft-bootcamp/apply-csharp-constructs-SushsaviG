using System;

namespace BMIValidationLib
{
    public class BMIValidatorType
    {
        
            public string BMIValidate(double bmiResult)
            {
                if (bmiResult < 18.5)
                {
                    return "Overweight";
                }
                else if (bmiResult >= 25)
                {
                    return "Healthy";
                }
                else
                {
                    return "Invalid Input";
                }
            }
        
    }
}
