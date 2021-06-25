using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo7
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double bmi = 0;

            BMIDATA h = new BMIDATA(1.372,56);
            h.Bmicalculationandvalidation();

        }
    }
}
