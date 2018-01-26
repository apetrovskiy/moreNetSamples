namespace Animals.Server.Modules
{
    using System.Linq;

    using Model;
    using Nancy;

    public class CatsModule: NancyModule
    {
        public CatsModule(): base("/v1")
        {
            Get["/cats"] = parameters => {
               // return View["allcats.html", Data.Cats];
               if (string.IsNullOrEmpty(this.Request.Query["name"].Value))
                    return View["allcats.html", Data.Cats]; 
                return GetCat(this.Request.Query["name"].Value);
            };

            Post["/cats"] = parameters => AddNewCat(this.Request.Query["name"].Value);

            Delete["/cats"] = parameters => DeleteCat(this.Request.Query["name"].Value);
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
            var cat = new Cat(name);
            Data.Cats.Add(cat);
            return HttpStatusCode.Created;
        }
    }
}