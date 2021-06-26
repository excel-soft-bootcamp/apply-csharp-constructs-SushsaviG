using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Identity_Information_Application
{
    class IDInformation
    {
        private string _Name;
        private string _Dob;
        private string _Validity;
        public idcardinformation(string name)
        {
            this._Name = name;
        }
        public idcardinformation(string name, string dob) : this(name)
        {
            this._Dob = dob;

        }
        public idcardinformation(string name, string dob, string validity) : this(name, dob)
        {
            this._Validity = validity;
        }

        public class StudentId : IDInformation
        {
            public string Branch;
            public string RollNo;
            public StudentId(string branch, string rollno, string name, string dob, string validity) : base(name, dob, validity)
            {
                this.Branch = branch;
                this.RollNo = rollno;
            }
        }
        public class Teachers :IDInformation
        {
            public string EmployeeNo;
            public string Qualification;
            public Teachers(string employeeno, string qualification, string name, string dob, string validity) : base(name, dob, validity)
            {
                this.EmployeeNo = employeeno;
                this.Qualification = qualification;
            }

        }
        public class Staff :IDInformation

        {
            public string Department;
            public Staff(string department, string name, string dob, string validity) : base(name, dob, validity)
            {
                this.Department = department;
            }
        }
        public class Guest :IDInformation
        {
            public string StudentName;
            public string StudentBranch;
            public Guest(string studentname, string studentbranch, string name, string dob, string validity) : base(name, dob, validity)
            {
                this.StudentName = StudentName;
                this.StudentBranch = studentbranch;
            }
        }

     
    }
}
