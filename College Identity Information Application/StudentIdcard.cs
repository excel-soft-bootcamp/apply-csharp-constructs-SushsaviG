using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Identity_Information_Application
{
    public class StudentIdcard:IDcard
    {
        public string Branch;
        public string RollNo;
        public string Bloodgroup;

        public StudentIdcard(string name, string branch,string bloodgroup, string rollno,string dob, string validity) : base(name, dob, validity)
           {
                this.Branch = branch;
                this.RollNo = rollno;
                this.Bloodgroup = bloodgroup;
            }
        
    }
}
