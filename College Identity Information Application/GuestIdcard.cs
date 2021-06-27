using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Identity_Information_Application
{
   public  class GuestIdcard:IDcard
    {
        public string StudentName;
        public string StudentBranch;
        public GuestIdcard(string studentname, string studentbranch, string name, string validity) : base(name, validity)
        {
            this.StudentName = studentname;
            this.StudentBranch = studentbranch;
        }

    }
}
