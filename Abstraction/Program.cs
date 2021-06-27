using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            VeriCorEngine _nexon = new VeriCorEngine();
            TATACAR car = new TATACAR(_nexon);
            car.Drive();
            DiCorEngine _harrier = new DiCorEngine();
            TATACAR car1 = new TATACAR(_nexon);
            car1.Drive();
            MultiJetEngine _hexa = new MultiJetEngine();
            TATACAR car3 = new TATACAR(_hexa);
            car3.Drive();

        }
    }
}
