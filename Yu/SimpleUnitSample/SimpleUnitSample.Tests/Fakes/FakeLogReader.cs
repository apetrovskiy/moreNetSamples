using SimpleUnitSample.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUnitSample.Tests.Fakes
{
    class FakeLogReader : ILogReader
    {
        public int LogType { get; internal set; } //= 1;

        public FakeLogReader(int logType = 1) {
            //LogType = 1;
            LogType = logType;
        }

        IEnumerable<string> ILogReader.Read(string path)
        {
            string data = string.Empty;

            switch (LogType)
            {
                case 1:
                    data = @"[Info: 11:32:03 25.05.18] Disconnected from Endur
[Info: 05:29:22 25.05.18] #ResetTestUsersAction.Reset started.
[Info: 05:29:26 25.05.18] #ResetTestUsersAction.Reset finished, elapsed 00:00:04.9382998.
[Info: 05:29:26 25.05.18] #ResetUserGroupsAction.Reset started.
[Info: 05:29:27 25.05.18] #ResetUserGroupsAction.Reset finished, elapsed 00:00:00.3897129.
[Info: 05:29:27 25.05.18] #ResetPartyUsersAction.Reset started.
[Info: 05:29:27 25.05.18] #ResetPartyUsersAction.Reset finished, elapsed 00:00:00.2531956.
[Info: 05:29:27 25.05.18] #ResetPortfolioUsersAction.Reset started.
[Info: 05:29:29 25.05.18] #ResetPortfolioUsersAction.Reset finished, elapsed 00:00:01.7735783.
[Info: 05:29:29 25.05.18] #ResetFunctionalGroupsAction.Reset started.
[Info: 05:29:29 25.05.18] #ResetFunctionalGroupsAction.Reset finished, elapsed 00:00:00.0971862.
[Info: 05:29:29 25.05.18] #ResetSecuredIndexesAction.Reset started.
[Info: 05:29:29 25.05.18] #ResetSecuredIndexesAction.Reset finished, elapsed 00:00:00.1032233.
[Info: 05:29:29 25.05.18] #ResetTestUserValidator.Validate started.";


                    break;
                default:
                    break;
            }

           


            return data.Split('\r');
        }
    }
}
