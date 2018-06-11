

using SimpleUnitSample.ObjectModel;
using System;

namespace SimpleUnitSample.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            test();

            testParser();
            Console.ReadLine();


        }

        static void test()
        {
            var c1 = new Class1();
            Console.WriteLine($"string {c1.strProp}");
            Console.WriteLine($" date {c1.dateProp}");
            Console.WriteLine($" date ? {c1.datePropNullable}");
            Console.WriteLine($" int {c1.intProp}");
            Console.WriteLine($" int ? {c1.intPropNullable}");
            Console.WriteLine($" bool {c1.boolProp}");
            Console.WriteLine($" bool ? {c1.boolPropNullable}");
            
        }

        static void testParser()
        {
            var pt1 = new ParserType1(new LogReader());
            var logEntries = pt1.Parse(@"Logs\log1.txt");
            logEntries.ForEach(e => Console.WriteLine($"level = {e.level}, date = {e.timeStamp}, message = {e.message}" )
                );

        }

    }
}
