namespace Objects.Server.Modules
{
	using Model;
	using Model.Dogs;
	using Nancy;

	public class AddDogsModule : NancyModule
	{
		public AddDogsModule() : base("/")
		{
			Post["dogs/{name}"] = parameters => AddNewDog(parameters.name);
		}

		private HttpStatusCode AddNewDog(string name)
		{
			var dog = new Dog(name);
			Data.Dogs.Add(dog);
			return HttpStatusCode.Created;
		}
	}
}