
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BMICalculationApplication
{
    public enum Options
    {
        CONSOLEINPUT = 1, FILEINPUT
    }
    class Program
    {
        static void Main(string[] args)
        {


            do
            {
                string Message = $"Enter Your Choice {(int)Options.CONSOLEINPUT}->ConsoleInput,{(int)Options.FILEINPUT}->FileInput";
                Console.WriteLine(Message);
                try
                {
                    Options _choice = (Options)Int32.Parse(Console.ReadLine());
                    if ((int)_choice = CONSOLEINPUT || (int)_choice = FILEINPUT)
                    {
                        CheckCondition checkCondition = new CheckCondition();
                        checkCondition.switchcondition(_choice);
                        Console.WriteLine(_choice);
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                        break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("enter a number");

                }
            } while (true);


        }

    }
}






