using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Identity_Information_Application
{
     public class StaffIdcard:IDcard
    {
        public string Department;
        public StaffIdcard(string department, string name, string dob, string validity) : base(name,validity)
        {
            this.Department = department;
        }

    }
}
