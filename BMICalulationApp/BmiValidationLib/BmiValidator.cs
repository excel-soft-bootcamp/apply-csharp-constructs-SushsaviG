using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiValidationLib
{
    public class BmiValidator
    {
        public static string BMIValidate(int bmivalue)
        {
            if (bmivalue < 18.5)
            {
                return "Underweight";
            }
            else if (bmivalue >= 25)
            {
                return "OverWeight";
            }
            else
            {
                return "Normal";
            }
        }
    }
}
