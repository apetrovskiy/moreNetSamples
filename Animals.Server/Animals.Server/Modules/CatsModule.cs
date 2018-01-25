namespace Animals.Server.Modules
{
    using System.ComponentModel;
    using System.Runtime.Remoting.Messaging;
    using Model;
    using Nancy;
    public class CatsModule: NancyModule
    {
        public CatsModule(): base("/v1")
        {
            Get["/cats"] = _ => {
                return View["allcats.html", Data.Cats];
            };

            Post["/cats"] = parameters => AddNewCat(this.Request.Query["name"].Value);
        }

        private HttpStatusCode AddNewCat(string name)
        {
            var cat = new Cat(name);
            Data.Cats.Add(cat);
            return HttpStatusCode.Created;
        }
    }
}