using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Identity_Information_Application
{
    public class TeacherIdcard:IDcard
    {
        public string Designation;
        public string Qualification;
        public TeacherIdcard(string name, string designation, string qualification, string validity) : base(name, validity)
        {
            this.Designation = designation;
            this.Qualification = qualification;
        }

    }
}
