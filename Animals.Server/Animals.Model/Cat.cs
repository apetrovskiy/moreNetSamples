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

        /*
        public Cat()
        {

        }
        */
    }
}
