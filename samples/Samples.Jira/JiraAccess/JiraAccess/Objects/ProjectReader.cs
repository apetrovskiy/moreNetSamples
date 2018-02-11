namespace JiraAccess.Objects
{
    using Jira.SDK.Domain;

    public class ProjectReader
    {
        public Project GetProject(string key)
        {
            return ConnectionCentre.Jira.GetProject(key);
        }
    }
}