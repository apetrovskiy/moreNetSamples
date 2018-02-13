namespace JiraAccess.Runner
{
    using System;
    using Objects;

    class Program
    {
        static void Main(string[] args)
        {
            var connectCentre = new ConnectionCentre();
            connectCentre.Connect("http://test0000003.atlassian.net", "admin", "11111111");

            var projectReader = new ProjectReader();
            var project = projectReader.GetProject("PROJ");

            Console.WriteLine(project.Name);
            Console.WriteLine(project.Lead.Name);
            Console.ReadKey();
        }
    }
}
