using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Architecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("Neo-organ", KindOfActivity.DemandMarketResearch, new Location("Ukraine", "Dnipro", "Kilomark", 1,123, new DateTime(2007,11,14)), new Shef("Jhon", "Brown", "Lentow", PositionOfShef.ChiefAccountant, new DateTime(2008,11,23)));
            //Console.WriteLine(company);
            Subdivision subdivision1 = new Subdivision("Directory Divis", KindOfActivity.WorkingWithClients, new Location("Ukraine", "Kiyv","Hmelnitchk", 3, 12, new DateTime(2008,7,14)), new Shef("Georg", "Markov", "Markovich", PositionOfShef.Director, new DateTime(2009, 8,17)));
            Subdivision subdivision2 = new Subdivision("Marketings", KindOfActivity.FinancialManagement, new Location("Ukraine", "Dnipro", "Kreschatik", 2, 45, new DateTime(2009, 5, 18)), new Shef("Hemes", "Nayal", "Petrovich", PositionOfShef.ChiefEngineer, new DateTime(2010, 3, 19)));
            company.AddSubdivision(subdivision1);
            company.AddSubdivision(subdivision2);
            subdivision1.ChangeLocation(new Location("Poland", "Kryakiv", "Gramms", 7, 320, new DateTime(2011, 12, 4)));
            subdivision1.AddPhoneNumber(new PhoneNumber("123-133-12-21", new DateTime(2007,12,5)));
            subdivision1.AddPhoneNumber(new PhoneNumber("675-456-12-54", new DateTime(2007, 12, 5)));
            subdivision1.AddPhoneNumber(new PhoneNumber("323-545-43-12", new DateTime(2007, 12, 5)));
            subdivision1.ChangePhoneNumber(1, new PhoneNumber("333-133-12-21", new DateTime(2007, 12, 5)));
            Console.WriteLine(company);
            subdivision1.outputHistory();
            subdivision1.ChangeShef(new Shef("Roma", "Kidal", "Martinov", PositionOfShef.ChiefAccountant, new DateTime(2008, 11, 12)));
            subdivision1.ChangeShef(new Shef("Hener", "Ger", "Bob", PositionOfShef.FinancialDirector, new DateTime(2008, 11, 12)));
            subdivision2.ChangeShef(new Shef("General", "Nost", "Bob", PositionOfShef.FinancialDirector, new DateTime(2008, 11, 12)));
            Console.WriteLine("\n\n\n\n\n\n"+company.GetSubdivisionWithMaxNumberShefs(new DateTime(2007, 11, 12), new DateTime(2007, 11, 12)));

        }
    }
}
