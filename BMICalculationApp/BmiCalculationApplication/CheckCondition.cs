using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApplication
{ 
    public class CheckCondition
    {public void switchcondition(Options _choice)
       {
            Switch(_choice)

            {case Options.CONSOLEINPUT:
             double height = BMIbodyInformationLib.BMIBodyInformationType.ReadBodyInformation();
                double weight = BMIbodyInformationLib.BMIBodyInformationType.ReadBodyInformation();

                double bmiValue = BMICalculateLib.BMICalculatorType.CalculateBMIResult(height, weight);

                string message = BMIValidationLib.BMIValidatorType.BMIValidate(bmiValue);

                BMIConsoleDisplayLib.ConsoleDisplayType.BMIDisplay(message);
                break;
             case Options.FILEINPUT:
            try
                {
                    string path = @" C:\Users\sushma.g\Documents\patient\PatientDetails";


                    string[] PatientDetail = File.ReadAllLines(path);
                    foreach (string line in PatientDetail)
                    {
                        string[] colums = line.Split(',');
                        string name = colums[0];
                        double _height = double.Parse(colums[1]);
                        double _weight = double.Parse(colums[2]);

                        double _BmiValue = BMICalculateLib.BMICalculatorType.CalculateBMIResult(_height, _weight);

                        string _Message = BMIValidationLib.BMIValidatorType.BMIValidate(_BmiValue);

                        Object[] patientData = new Object[5];
                        patientData[0] = name;
                        patientData[1] = _height;
                        patientData[2] = _weight;
                        patientData[3] = _BmiValue;
                        patientData[4] = _Message;

                        foreach (int data in patientData)
                        {
                            Console.Write(data[i] + "\t");
                        }
                        Console.WriteLine();
                    }
                }

                catch (FileNotFoundException exception)
                {
                    Console.WriteLine("InValid Path");
                }

                break;


            }

        }

    }
}
