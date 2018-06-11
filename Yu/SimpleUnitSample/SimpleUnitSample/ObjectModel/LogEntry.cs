using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUnitSample.ObjectModel
{
    public class LogEntry
    {
        public DateTime timeStamp { get; set; }
        public LogEntryLevels level { get; set; }
        public string message { get; set; }
    }
}
