using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleUnitSample.ObjectModel
{
    public class ParserType1 : IParser
    {
        readonly ILogReader logReader;
        //private SimpleUnitSample.Tests.Fakes.FakeLogReader fakeLogReader;

        public ParserType1(ILogReader log)
        {
            this.logReader = log;
        }

        //public ParserType1(SimpleUnitSample.Tests.Fakes.FakeLogReader fakeLogReader)
        //{
        //    this.fakeLogReader = fakeLogReader;
        //}

        public List<LogEntry> Parse(string path)
        {

           // var logReader = new LogReader();
            var resultLines = logReader.Read(path);

            //            [Info: 05:29:32 25.05.18] #RestartWindowsServiceAction.Restart finished, elapsed 00:00:02.2887519.
            //[Info: 05:29:32 25.05.18] #RestartWindowsServiceAction.Restart started.
            //[Info: 05:29:32 25.05.18]
            //        Restarting EndurDealLifecycleService on ENDAPP82QA
            //[Info: 05:29:35 25.05.18] #RestartWindowsServiceAction.Restart finished, elapsed 00:00:03.2137709.

            return resultLines.Select(item => new LogEntry
            {
                level = GetLogEntryLevels(item),
                timeStamp = GetTimeStamp(item),
                message = GetMessage(item)
            }
            ).ToList();

        }

        LogEntryLevels GetLogEntryLevels(string data)
        {
            // var ourValue = Regex.Match(data, @"[^\[][^:]*").Groups[0].Value;
            var ourValue = Regex.Match(data, @"(?<=\[)[^:]*").Value;
            return (SimpleUnitSample.ObjectModel.LogEntryLevels)Enum.Parse(typeof(LogEntryLevels), ourValue);
        }

        DateTime GetTimeStamp(string data)
        {
            return DateTime.Now;
        }

        string GetMessage(string data)
        {
            return " ";
        }

    }
}
