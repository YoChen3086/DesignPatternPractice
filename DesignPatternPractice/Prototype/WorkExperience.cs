using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class WorkExperience : ICloneable
    {
        private string workDate;
        private string company;

        public string WorkDate
        {
            get { return workDate; }
            set { workDate = value; }
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
