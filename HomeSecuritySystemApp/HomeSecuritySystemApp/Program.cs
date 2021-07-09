using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySystemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SecuritySystem _system = new SecuritySystem();
            DoorSensor sensor = new DoorSensor();
            SecurityStatusOfDoor securitystatus = new SecurityStatusOfDoor(sensor.open);
            
            sensor.Notification(securitystatus);
            




        }
    }
}
