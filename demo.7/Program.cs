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
            bmi = h.height / h.weight * 2;
            if(bmi<18.5)
            {
                Console.WriteLine("underweight");
                Console.ReadLine();

            }
            if(bmi>=25)
            {
                Console.WriteLine("overweight");
                Console.ReadLine();
            }
            if(bmi>18.5&&bmi<25)
            {
                Console.WriteLine("healthy");
                Console.ReadLine();
            }
            

        }
    }
}
