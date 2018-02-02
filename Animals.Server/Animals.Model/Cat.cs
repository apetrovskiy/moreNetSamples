namespace Animals.Model
{
    public class Cat
    {
        private static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public bool Owned { get; set; }
        public int Age { get; set; }

        public Cat(string name): this()
        {
            Name = name;
        }

        public Cat()
        {
            Id = ++counter; 
        }
    }
}
