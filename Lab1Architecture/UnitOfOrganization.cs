using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Architecture
{
    /// <summary>
    /// The base class for Companies and Subdivisions
    /// </summary>
    class UnitOfOrganization
        
    {
        protected string nameOfUnit;
        protected KindOfActivity kindOfActivity;
        protected Location location;
        protected List<PhoneNumber> phoneNumbers = new List<PhoneNumber>();
        protected Shef shef;
        protected HistoryOfChanging<Location> historyOfLocationChanging;
        protected HistoryOfChanging<PhoneNumber> historyOfPhoneNumberChanging;
        protected HistoryOfChanging<Shef> historyOfShefChanging;
        protected string email;
    }
    
}
