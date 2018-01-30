namespace Animals.Server.Modules.V2
{
    using System.Xml;
    using Model;
    using Nancy;
    using Nancy.ModelBinding;

    public class CatsModule : NancyModule
    {
        public CatsModule() : base("/V2")
        {
            Post["/cats"] = _ => AddNewCat();
        }

        private HttpStatusCode AddNewCat()
        {
            var cat = this.Bind<Cat>();

            // TODO: give it some sense
            return HttpStatusCode.BadGateway;
        }
    }
}