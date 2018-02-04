namespace PollySample.Runner
{
	using System;

	class Program
    {
        static void Main(string[] args)
        {
	        new SimpleTest().RunPolicyWithRetry();

	        Console.ReadKey();
        }
    }
}
