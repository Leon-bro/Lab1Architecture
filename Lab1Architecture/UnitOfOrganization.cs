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

        public string NameOfUnit { get; set; }
        public Location Location { get=> location; }
        protected KindOfActivity kindOfActivity;
        protected Location location;
        protected List<PhoneNumber> phoneNumbers = new List<PhoneNumber>();
        protected Shef shef;
        string email;
        public string Email { get => email;
            set
            {
                try
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new Exception("Email may not be empty");
                    }
                    else
                    {
                        email = value;
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
        protected HistoryOfChanging<Location> historyOfLocationChanging;
        protected HistoryOfChanging<PhoneNumber> historyOfPhoneNumberChanging;
        protected HistoryOfChanging<Shef> historyOfShefChanging;
        delegate void SaveToHistoryLocationDelegate(Location objectToSave, HistoryOfChanging<Location> historyOfChanging);
        delegate void SaveToHistoryPhoneNumberDelegate(PhoneNumber objectToSave, HistoryOfChanging<PhoneNumber> historyOfChanging);
        delegate void SaveToHistoryShefDelegate(Shef objectToSave, HistoryOfChanging<Shef> historyOfChanging);
        event SaveToHistoryLocationDelegate LocSave;
        event SaveToHistoryPhoneNumberDelegate PhoneSave;
        event SaveToHistoryShefDelegate ShefSave;
        public UnitOfOrganization(string nameOfOrgan, KindOfActivity kindOfActivity, Location location, Shef shef)
        {
            NameOfUnit = nameOfOrgan;
            this.kindOfActivity = kindOfActivity;
            this.location = location;
            this.shef = shef;
            LocSave += SaveToHistory;
            PhoneSave += SaveToHistory;
            ShefSave += SaveToHistory;
            historyOfLocationChanging = new HistoryOfChanging<Location>();
            historyOfPhoneNumberChanging = new HistoryOfChanging<PhoneNumber>();
            historyOfShefChanging = new HistoryOfChanging<Shef>();
        }
        public void AddPhoneNumber(PhoneNumber phoneNumber)
        {
            phoneNumbers.Add(phoneNumber);
        }
        /// <summary>
        /// The method are to automatically save the history of changes of location.
        /// </summary>
        /// <param name="location">The new location</param>
        public void ChangeLocation(Location location)
        {
            LocSave?.Invoke(this.location, historyOfLocationChanging);
            this.location = location;
        }
        /// <summary>
        ///  The method are to automatically save the history of changes of phone number.
        ///  Can be changed only only one phone number at a time.
        /// </summary>
        /// <param name="indexPhone">Number of phone number in the list</param>
        /// <param name="phone">New phone</param>
        public void ChangePhoneNumber(int indexPhone, PhoneNumber phone)
        {
            PhoneSave?.Invoke(this.phoneNumbers[indexPhone], historyOfPhoneNumberChanging);
            this.phoneNumbers[indexPhone] = phone;
            
        }
        /// <summary>
        ///  The method are to automatically save the history of changes of shefs.
        /// </summary>
        /// <param name="shef">New shef</param>
        public void ChangeShef(Shef shef)
        {
            ShefSave?.Invoke(this.shef, historyOfShefChanging);
            this.shef = shef;
            
        }

        private void SaveToHistory<T>(T objectToSave, HistoryOfChanging<T> historyOfChanging) where T: DateOfCommit
        {
            historyOfChanging.AddRecordToStoryList(objectToSave);
        }
        public override string ToString() => $"Name of unit of organisation: {NameOfUnit} \n" +
                $"Kind of activity: {kindOfActivity}\n" +
                $"Location: {location}" +
                $"Phone numbers:\n {String.Join(";\n", phoneNumbers)}\n" +
                $"Shef:\n {shef}" +
                $"Email: {email}\n";
        /// <summary>
        /// To show history of element
        /// </summary>
        public void outputHistory()
        {
            Console.WriteLine("Name:"+ NameOfUnit);
            Console.WriteLine("Locations: " + historyOfLocationChanging);
            Console.WriteLine("Phone numbers: " + historyOfPhoneNumberChanging);
            Console.WriteLine("Shefs: "+historyOfShefChanging);
        }

        public List<PhoneNumber> GetHistoryByDate(DateTime dateTime)
        {
            return historyOfPhoneNumberChanging.GetHistoryByDate(dateTime);
        }
    }
    
}
