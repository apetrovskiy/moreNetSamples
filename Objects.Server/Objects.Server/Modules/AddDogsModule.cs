namespace Objects.Server.Modules
{
	using Model;
	using Model.Dogs;
	using Nancy;

	public class AddDogsModule : NancyModule
	{
		public AddDogsModule() : base("/")
		{
			Post["dogs"] = _ => AddNewDog(this.Request.Query["name"].Value);
		}

		private HttpStatusCode AddNewDog(string name)
		{
			var dog = new Dog(name);
			Data.Dogs.Add(dog);
			return HttpStatusCode.Created;
		}
	}
}