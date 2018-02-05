namespace ReportingSample.Runner
{
    using DotLiquid;
    using MarkDown;
    using Nustache;
    using Spark;

    class Program
    {
        static void Main(string[] args)
        {
            new Class1DotLiquid().Run();
            new Class1MarkDown().Run();
            new Class1Nustache().Run();
            new Class1Spark().Run();
        }
    }
}
