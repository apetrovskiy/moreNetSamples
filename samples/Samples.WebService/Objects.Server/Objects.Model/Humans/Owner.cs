namespace Objects.Model.Humans
{
    using System.Collections.Generic;
    using Dogs;

    public class Owner
    {
		public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public List<Dog> Dogs { get; set; }

        public Owner(string firstName, string lastName, List<Dog> dogs)
        {
            this.FirstName = firstName;
            this.Surname = lastName;
            this.Dogs = null == dogs ? new List<Dog>() : dogs;
	        this.Id = ++Data.OwnersCounter;
        }
    }
}