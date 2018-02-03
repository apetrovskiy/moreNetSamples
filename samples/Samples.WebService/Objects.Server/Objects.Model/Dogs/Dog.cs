namespace Objects.Model.Dogs
{
    using System.Collections.Generic;

    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        public int Age { get; set; }
        public bool IsVaccinated { get; set; }

        public Dog(string name) : this()
        {
            this.Name = name;
        }

        public Dog()
        {
            this.Id = ++Data.DogsCounter;
        }
    }
}
