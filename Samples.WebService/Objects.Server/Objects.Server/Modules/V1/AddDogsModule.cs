namespace Objects.Server.Modules.V1
{
	using System.Linq;
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
			if (Data.Dogs.Any() && Data.Dogs.Select(dog1 => dog1.Name.ToUpper()).Contains(name.ToUpper())) return HttpStatusCode.NotAcceptable;
			var dog = new Dog(name);
			Data.Dogs.Add(dog);
			return HttpStatusCode.Created;
		}
	}
}