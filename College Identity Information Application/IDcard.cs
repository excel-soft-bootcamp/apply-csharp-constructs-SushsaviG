using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Identity_Information_Application
{
    public class IDcard
    {
        private string _Name;
        private string _Dob;
        private string _Validity;
        public IDcard(string name, string validity)
        {
            this._Name = name;
            this._Validity = validity;
        }

        public IDcard(string name, string dob, string validity) : this(name, validity)
        {
            this._Dob=dob;
        }
    }
}
