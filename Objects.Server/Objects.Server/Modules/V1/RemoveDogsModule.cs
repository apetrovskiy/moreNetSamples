namespace Objects.Server.Modules.V1
{
	using Model;
	using Nancy;

	public class RemoveDogsModule : NancyModule
	{
		public RemoveDogsModule() : base(Constants.Version01)
		{
			Delete[Constants.Dogs] = _ => DeleteDogByName(this.Request.Query["name"].Value);
		}

		private HttpStatusCode DeleteDogByName(string name)
		{
			Data.Dogs.RemoveAll(dog => dog.Name.ToUpper() == name.ToUpper());
			return HttpStatusCode.NoContent;
		}
	}
}