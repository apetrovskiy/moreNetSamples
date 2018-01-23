namespace Objects.Runner.Modules
{
    using System.Linq;
    using Model;
    using Nancy;

    public class ShowDogsModule : NancyModule
    {
        public ShowDogsModule() : base("/")
        {
            Get["dogs/"] = _ => { return View["index.html", Data.Dogs]; };
            Get["dogs1/"] = _ => { return Data.Dogs; };
            Get["dogs/{name}"] = parameters => { return Data.Dogs.First(dog => dog.Name.ToUpper() == parameters.name.ToString().ToUpper()); };
        }
    }
}