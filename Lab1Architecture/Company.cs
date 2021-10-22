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
    }
}
