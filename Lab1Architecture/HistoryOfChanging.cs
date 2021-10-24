using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Architecture
{
    /// <summary>
    /// The class saves the changes.
    /// </summary>
    /// <typeparam name="T"> There can be classes inherited from DateOfCommit that contain the date of the commit. For example, Location.</typeparam>
    class HistoryOfChanging <T> where T: DateOfCommit
    {
        List<T> history;
        public HistoryOfChanging()
        {
            history = new List<T>();
        }
        public void AddRecordToStoryList(T record)
        {
            history.Add(record);
        }
        public List<T> GetHistoryByDate(DateTime dateTime)
        {
            return (from t in history where t.DateOfFix.Day == dateTime.Day && 
                    t.DateOfFix.Month == dateTime.Month && 
                    t.DateOfFix.Year == dateTime.Year select t).ToList();
        }
        public List<T> GetHistoryBetweenDates(DateTime dateTimeStart, DateTime dateTimeFinish)
        {
            return (from t in history
                    where t.DateOfFix> dateTimeStart && t.DateOfFix<= dateTimeFinish
                    select t).ToList();
        }
        public int GetAmountOfChanging()
        {
            return history.Count;
        }
        public override string ToString()
        {
            return String.Join(";\n", history);
        }
    }
}
