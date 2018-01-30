namespace TodoNancy
{
    using System;
    using Nancy;
    using Nancy.TinyIoc;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            var mongoDataStore = new MongoDataStore("mongodb://localhost:27919/todos");
            container.Register<IDataStore>(mongoDataStore);
        }
    }
}