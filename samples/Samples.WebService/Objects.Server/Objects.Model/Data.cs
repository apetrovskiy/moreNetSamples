namespace Objects.Model
{
    using System.Collections.Generic;
    using Dogs;
    using Humans;

    public class Data
    {
        public static List<Dog> Dogs { get; set; }
        public static List<Owner> Owners { get; set; }
		public static int DogsCounter { get; set; }
		public static int OwnersCounter { get; set; }
    }
}