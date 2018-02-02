namespace Objects.Server.Modules.V2
{
    using System.Linq;
    using Model;
    using Model.Dogs;
    using Nancy;
    using Nancy.ModelBinding;
    using Nancy.Responses.Negotiation;

	public class DogsV2Module : NancyModule
    {
        public DogsV2Module() : base("/v2")
        {
            Get("/dogs", _ => View["dogs.html", Data.Dogs]);
            Get("/newDog", _ => View["newDog.html"]);
            // Post("/newDog", _ => AddNewDog(this.Bind<Dog>()));
			Post("/newDog", _ => AddNewDog(this.Bind<Dog>()));
            // Get("/dogs");
        }

		// private HttpStatusCode AddNewDog(Dog dog)
		private Negotiator AddNewDog(Dog dog)
		{
            if (null == dog) return Negotiate.WithStatusCode(HttpStatusCode.NotAcceptable);
            if (Data.Dogs.Select(dg => dg.Name.ToUpper()).Contains(dog.Name.ToUpper())) return Negotiate.WithStatusCode(HttpStatusCode.NotAcceptable);
            Data.Dogs.Add(dog);
            // return HttpStatusCode.Created;
			return Negotiate
				.WithStatusCode(HttpStatusCode.Created)
				.WithView("dogs.html")
				.WithModel(Data.Dogs)
				.WithFullNegotiation();
		}
    }
}