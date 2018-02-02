namespace Animals.Server.Modules.V2
{
    using System.Linq;
    using System.Xml;
    using Model;
    using Nancy;
    using Nancy.ModelBinding;

    public class CatsModule : NancyModule
    {
        public CatsModule() : base("/V2")
        {
            Post("/newcat",_ => AddNewCat());
			
			// the fix
			Get("/newcat", _ => View["newCat.html"]);

            Get("/cats", _ => {
                if (string.IsNullOrEmpty(this.Request.Query["name"].Value))
                    return View["allcats.html", Data.Cats];
                return GetCat(this.Request.Query["name"].Value);
            });

            Delete("/cats", parameters => DeleteCat(this.Request.Query["name"].Value));
        }

        private Response AddNewCat()
        {
            var cat = this.Bind<Cat>();
            if (null == cat || string.IsNullOrEmpty(cat.Name)) return HttpStatusCode.NotAcceptable;
            if (Data.Cats.Select(cat1 => cat1.Name.ToUpper()).Contains(cat.Name.ToUpper())) return HttpStatusCode.NotAcceptable;
            Data.Cats.Add(cat);

            //return HttpStatusCode.Created;
            return Response.Context.Response
                .WithStatusCode(HttpStatusCode.Created);
            //.StatusCode..StatusCode..
        }

        private Cat GetCat(string name)
        {
            return Data.Cats.First(cat => cat.Name.ToLower() == name.ToLower());
        }
        private HttpStatusCode DeleteCat(string name)
        {
            Data.Cats.RemoveAll(cat => cat.Name.ToLower() == name.ToLower());
            return HttpStatusCode.OK;
        }
    }
}