namespace JiraAccess
{
    using Jira.SDK;
    using Jira = Jira.SDK.Jira;

    public class ConnectionCentre
    {
        public static Jira Jira { get; set; }
        public void Connect(string serverUrl, string username, string password)
        {
            Jira = new Jira();
            Jira.Connect(new JiraClient(serverUrl, username, password));
        }
    }
}
