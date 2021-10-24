using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Architecture
{
    /// <summary>
    /// The class for attaching the dates of fixing to classes like Location, Shef and PhoneNumber
    /// </summary>
    abstract class DateOfCommit
    {
        
        DateTime dateOfFix;
        public DateTime DateOfFix { get => dateOfFix; }
        protected void SetDateOfFixing(DateTime dateOfFix)
        {
            this.dateOfFix = dateOfFix;
        }
        public override string ToString()
        {
            return "Date of commit: "+ DateOfFix.Date;
        }
    }
}
