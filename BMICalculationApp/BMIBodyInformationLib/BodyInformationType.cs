using System;

namespace BMIBodyInformationLib
{
    public class BodyInformationType
    {
        public double ReadBodyInformation(string message)
        {
            Console.WriteLine(message);
                double value = Convert.ToDouble(Console.ReadLine());
            return value;
        }
    }
}
