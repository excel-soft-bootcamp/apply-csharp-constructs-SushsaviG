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

            Health h = new Health(1.372,56);
           double  r1=h.M1(1.372, 56);
            Console.WriteLine(r1);
            Console.ReadLine();
            

        }
    }
}
