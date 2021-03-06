using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Architecture
{
    class Subdivision : UnitOfOrganization
    {
        public Subdivision(string nameOfOrgan, KindOfActivity kindOfActivity, Location location, Shef shef)
            : base(nameOfOrgan, kindOfActivity, location, shef)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
        public int GetValueShefs(DateTime dateTime1, DateTime dateTime2)
        {
            return historyOfShefChanging.GetLengthOfStoryByDate(dateTime1, dateTime2);
        }
        public string GetWithPhoneNumbers(DateTime dateTime)
        {
            
            return $"Name of subdivision: {NameOfUnit};\n" +
                $"Phone numbers: \n{String.Join("\n", historyOfPhoneNumberChanging.GetHistoryByDate(dateTime))}";
        }
    }
}
