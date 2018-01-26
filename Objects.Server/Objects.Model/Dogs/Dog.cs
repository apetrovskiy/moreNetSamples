namespace Objects.Model.Dogs
{
    using System.Collections.Generic;

    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Head Head { get; set; }
        public List<Paw> Paws { get; set; }
        public Tail Tail { get; set; }
        public bool IsVaccinated { get; set; }

        public Dog(string name)
        {
            this.Name = name;
	        this.Id = ++Data.DogsCounter;
        }
    }
}
