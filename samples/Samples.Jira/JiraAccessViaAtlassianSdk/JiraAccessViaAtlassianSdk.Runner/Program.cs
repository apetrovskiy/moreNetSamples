namespace JiraAccessViaAtlassianSdk.Runner
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            new ConnectionHelper().Connect("http://test0000003.atlassian.net", "admin", "11111111");

            Console.WriteLine("Hello World!");
        }
    }
}
