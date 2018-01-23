namespace Objects.Server.Modules
{
	using System.Linq;
	using Model;
	using Nancy;

	public class ShowDogsModule : NancyModule
    {
        public ShowDogsModule() : base("/")
        {
            Get["dogs/"] = _ => View["index.html", Data.Dogs];
            Get["dogs1/"] = _ => Data.Dogs;
            Get["dogs/{name}"] = parameters => { return Data.Dogs.First(dog => dog.Name.ToUpper() == parameters.name.ToString().ToUpper()); };
        }
    }
}