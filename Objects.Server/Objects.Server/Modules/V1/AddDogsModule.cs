namespace Objects.Server.Modules.V1
{
	using Model;
	using Model.Dogs;
	using Nancy;

	public class AddDogsModule : NancyModule
	{
		public AddDogsModule() : base(Constants.Version01)
		{
			Post[Constants.Dogs] = _ => AddNewDog(this.Request.Query["name"].Value);
		}

		private HttpStatusCode AddNewDog(string name)
		{
			var dog = new Dog(name);
			Data.Dogs.Add(dog);
			return HttpStatusCode.Created;
		}
	}
}