namespace Animals.Server.Modules.V2
{
    using System.Linq;
    using System.Xml;
    using Model;
    using Nancy;
    using Nancy.ModelBinding;
    using Nancy.Responses.Negotiation;
    using Serilog;

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

        private Negotiator AddNewCat()
        {
            var log = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
            var log2 = new LoggerConfiguration()
                .WriteTo.File(@".\log.log")
                .CreateLogger();

            log.Information("Start");
            log2.Information("Start");

            var cat = this.Bind<Cat>();
            if (null == cat || string.IsNullOrEmpty(cat.Name)) return Negotiate.WithStatusCode(HttpStatusCode.NotAcceptable);
            if (Data.Cats.Select(cat1 => cat1.Name.ToUpper()).Contains(cat.Name.ToUpper())) return Negotiate.WithStatusCode(HttpStatusCode.NotAcceptable);
            log.Information("Cat: {@cat}", cat);
            log2.Information("Cat: {@cat}", cat);
            Data.Cats.Add(cat);

            // the fix
            // return HttpStatusCode.Created;
            return Negotiate
                    .WithFullNegotiation()
                    .WithModel(Data.Cats)
                    .WithStatusCode(HttpStatusCode.Created)
                    .WithView("allcats.html");
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