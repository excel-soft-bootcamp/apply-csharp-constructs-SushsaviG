using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySystemApp
{
    public delegate string SecurityStatusOfDoor(string state); 
   public  class DoorSensor
    {
        string Doorstatus;

        public event SecurityStatusOfDoor _Doorstatus;
        public void Open()
        {
            Doorstatus = "Closed";
            this.Notification();


        }
        public void Close()
        {
            Doorstatus = "Closed";
            this.Notification();

        }
        public void Notification()
        {

            _Doorstatus.Invoke(Doorstatus);
        }

    }
    
}
