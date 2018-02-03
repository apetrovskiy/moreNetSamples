namespace Objects.Server.Modules.V1
{
	using System.Linq;
	using Model;
	using Model.Dogs;
	using Nancy;

	public class ShowDogsModule : NancyModule
    {
        public ShowDogsModule() : base(Constants.Version01)
        {
            Get("/dogs1", _ => Data.Dogs);
            Get(Constants.Dogs + "/{name}", parameters => { return Data.Dogs.First(dog => dog.Name.ToUpper() == parameters.name.ToString().ToUpper()); });
	        Get(Constants.Dogs, parameters =>
	        {
		        return string.IsNullOrEmpty(this.Request.Query["name"].Value) ? View["index.html", Data.Dogs] : GetDogByName(this.Request.Query["name"].Value);
	        });
		}

	    private Dog GetDogByName(string name)
	    {
		    var repository = new Repository.DogsRepository();
			// repository.
		    repository.GetAllDogs();
		    return Data.Dogs.First(dog => dog.Name.ToUpper() == name.ToUpper());
	    }
    }
}