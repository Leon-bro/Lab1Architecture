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
        
    }
}
