namespace Animals.Server.Modules.V1
{
    using System.Linq;
    using Model;
    using Nancy;

    public class CatsV1Module: NancyModule
    {
        public CatsV1Module(): base("/v1")
        {
            Get("/cats", parameters => {
               // return View["allcats.html", Data.Cats];
               if (string.IsNullOrEmpty(this.Request.Query["name"].Value))
                    return View["allcats.html", Data.Cats]; 
                return GetCat(this.Request.Query["name"].Value);
            });

            Post("/cats", parameters => AddNewCat(this.Request.Query["name"].Value));

            Delete("/cats", parameters => DeleteCat(this.Request.Query["name"].Value));
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

        private HttpStatusCode AddNewCat(string name)
        {
            if (Data.Cats.Select(cat1 => cat1.Name.ToUpper()).Contains(name.ToUpper())) return HttpStatusCode.NotAcceptable;
            var cat = new Cat(name);
            Data.Cats.Add(cat);
            return HttpStatusCode.Created;
        }
    }
}