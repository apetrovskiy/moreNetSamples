namespace Objects.Server.Modules
{
	using System.Linq;
	using Model;
	using Model.Dogs;
	using Nancy;

	public class ShowDogsModule : NancyModule
    {
        public ShowDogsModule() : base("/")
        {
            Get["dogs1"] = _ => Data.Dogs;
            Get["dogs/{name}"] = parameters => { return Data.Dogs.First(dog => dog.Name.ToUpper() == parameters.name.ToString().ToUpper()); };
	        Get["dogs"] = parameters =>
	        {
		        return string.IsNullOrEmpty(this.Request.Query["name"].Value) ? View["index.html", Data.Dogs] : GetDogByName(this.Request.Query["name"].Value);
	        };
		}

	    private Dog GetDogByName(string name)
	    {
		    return Data.Dogs.First(dog => dog.Name.ToUpper() == name.ToUpper());
	    }
    }
}