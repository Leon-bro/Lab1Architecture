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
    }
}
