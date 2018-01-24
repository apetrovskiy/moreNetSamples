namespace Objects.Server.Modules
{
	using Model;
	using Nancy;

	public class RemoveDogsModule : NancyModule
	{
		public RemoveDogsModule() : base("/")
		{
			Delete["dogs/"] = _ => DeleteDogByName(this.Request.Query["name"].Value);
		}

		private HttpStatusCode DeleteDogByName(string name)
		{
			Data.Dogs.RemoveAll(dog => dog.Name.ToUpper() == name.ToUpper());
			return HttpStatusCode.NoContent;
		}
	}
}