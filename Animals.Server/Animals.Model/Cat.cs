using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Model
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Cat(string name)
        {
            Name = name;
        }
    }
}
