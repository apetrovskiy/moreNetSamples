namespace JiraAccessViaAtlassianSdk
{
    using Atlassian.Jira;

    public class ConnectionHelper
    {
        public void Connect(string serverUrl, string username, string password)
        {
            var result = Jira.CreateRestClient(serverUrl, username, password);

            int i = 1;
        }
    }
}
