namespace Objects.Runner
{
	using System;
	using System.Linq;
	using Model;
    using Model.Dogs;
    using Model.Humans;
    using Nancy.Hosting.Self;

    class Program
    {
        static void Main(string[] args)
        {
            Data.Dogs = new[] {new Dog("Sharik"), new Dog("Toozik"), new Dog("Jack Russell")}.ToList();
            Data.Dogs[1].IsVaccinated = true;
            Data.Owners = new[] {new Owner("John", "Smith", new[]{ Data.Dogs[0]}.ToList()), new Owner("Bill", "Gates", new[]{Data.Dogs[1], Data.Dogs[2]}.ToList())}.ToList();

            using (var host = new NancyHost(new Uri("http://localhost:1234")))
            {
                Console.WriteLine("Starting...");
                host.Start();
                Console.WriteLine("the host has started");
                Console.ReadKey();
            }
        }
    }
}
