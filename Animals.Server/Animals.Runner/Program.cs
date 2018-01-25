using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Runner
{
    using Model;
    using Nancy.Hosting.Self;

    class Program
    {
        static void Main(string[] args)
        {
            Data.Cats = new List<Cat>(new []{new Cat("Murka"), new Cat("Vaska"), new Cat("Barsik"),  }.ToList());

            using (var host = new NancyHost(new Uri("http://localhost:1235")))
            {
                host.Start();
                Console.WriteLine("Running on http://localhost:1235");
                Console.ReadLine();
            };
        }
    }
}
