namespace Objects.Server.Modules.V2
{
    using System.Linq;
    using Model;
    using Model.Dogs;
    using Nancy;
    using Nancy.ModelBinding;

    public class DogsV2Module : NancyModule
    {
        public DogsV2Module() : base("/v2")
        {
            Get("/dogs", _ => View["dogs.html", Data.Dogs]);
            Get("/newDog", _ => View["newDog.html"]);
            Post("/newDog", _ => AddNewDog(this.Bind<Dog>()));
            // Get("/dogs");
        }

        private HttpStatusCode AddNewDog(Dog dog)
        {
            if (null == dog) return HttpStatusCode.NotAcceptable;
            if (Data.Dogs.Select(dg => dg.Name.ToUpper()).Contains(dog.Name.ToUpper())) return HttpStatusCode.NotAcceptable;
            Data.Dogs.Add(dog);
            return HttpStatusCode.Created;
        }
    }
}