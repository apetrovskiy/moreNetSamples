using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Runner
{
    using Model;

    class Program
    {
        static void Main(string[] args)
        {
            Data.Cats = new List<Cat>(new []{new Cat("Murka"), new Cat("Vaska"), new Cat("Barsik"),  }.ToList());

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
