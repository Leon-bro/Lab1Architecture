using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Architecture
{
    class Company : UnitOfOrganization
    {
        int ID;
        List<Subdivision> subdivisions = new List<Subdivision>();
        public Company(string nameOfOrgan, KindOfActivity kindOfActivity, Location location, Shef shef)
            : base(nameOfOrgan, kindOfActivity, location, shef)
        {

        }
        public void AddSubdivision(Subdivision subdivision)
        {
            subdivisions.Add(subdivision);
        }
        public override string ToString()
        {
            return "\t\tCompany:\n"+base.ToString()+ "\tSubdivisions: \n" + String.Join("\n", subdivisions);
        }
        public string GetSubdivisionWithMaxNumberShefs(DateTime dateTime1, DateTime dateTime2)
        {
            int max = subdivisions.Max(o => o.GetValueShefs(dateTime1, dateTime2));
            return subdivisions.First(e => e.GetValueShefs(dateTime1, dateTime2) == max).NameOfUnit.ToString();
        }
    }
}
