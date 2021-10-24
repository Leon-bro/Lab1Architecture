using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Architecture
{
    class Location : DateOfCommit
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int HomeNumber { get; set; }
        public int RoomNumber { get; set; }
        public Location(string country, string city, string region, int homeNumber, int roomNumber, DateTime dateOfCommit)
        {
            Country = country;
            City = city;
            Region = region;
            HomeNumber = homeNumber;
            RoomNumber = roomNumber;
            SetDateOfFixing(dateOfCommit);
        }
        public override string ToString()
        {
            return $" {Country}, {City}, {Region}, {HomeNumber}-{RoomNumber}; " + base.ToString();
        }


    }

}
