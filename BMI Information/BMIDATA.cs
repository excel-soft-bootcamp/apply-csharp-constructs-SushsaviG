using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo7
{
    class BMIDATA
    {
        public double height;
        public double weight;
        public double bmi;
        public BMIDATA(double height, double weight)

        {
            this.height = height;
            this.weight = weight;

        }
        public double Bmicalculationandvalidation(double height, double weight)
        {
            bmi = height / weight * 2;
            if (bmi < 18.5)
            {
                Console.WriteLine("underweight");
                Console.ReadLine();

            }
            if (bmi >= 25)
            {
                Console.WriteLine("overweight");
                Console.ReadLine();
            }
            if (bmi > 18.5 && bmi < 25)
            {
                Console.WriteLine("healthy");
                Console.ReadLine();
            }
        }
    }
}
