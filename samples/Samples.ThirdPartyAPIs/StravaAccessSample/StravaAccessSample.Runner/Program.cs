namespace StravaAccessSample.Runner
{
	using System;

	class Program
    {
        static void Main(string[] args)
        {
            var dataLoader = new DataLoader();
            dataLoader.GetActivities("7b8812f489c128c99fd0fedec24d30cb0ea211bf");

            Console.ReadKey();
        }
    }
}
