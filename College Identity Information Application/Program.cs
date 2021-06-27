using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Identity_Information_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentIdcard S = new StudentIdcard("Swathi", "o+ve", "23", "23-09-1997", "2019-2022","science");
            Console.WriteLine(S);
            
        }
    }
}
