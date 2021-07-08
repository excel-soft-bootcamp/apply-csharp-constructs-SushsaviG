using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIbodyInformationLib
{
    public class BMIBodyInformationType
    {
        public double ReadBodyInformation(string message)
        {
           
            double value = Convert.ToDouble(Console.ReadLine());
            return value;
        }
    }
}
