using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Architecture
{
    /// <summary>
    /// Phone number of Company or Subdivision
    /// </summary>
    class PhoneNumber : DateOfCommit
    {
        string number;
        public PhoneNumber(string number, DateTime dateTime)
        {
            this.number = number;
            SetDateOfFixing(dateTime);
        }
        public override string ToString()
        {
            return $"{number} " + base.ToString();
        }
    }
}
