using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Architecture
{
    /// <summary>
    /// the class is Shef of Company or Subdivision
    /// </summary>
    class Shef : DateOfCommit
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public PositionOfShef PositionOfShef { get; set; }
        public Shef(string firstName, string lastName, string patronymic, PositionOfShef positionOfShef)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            PositionOfShef = positionOfShef;
        }
    }
}
