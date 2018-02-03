namespace NancyOnAspNet
{
    using Nancy;

    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/"] = _ => "Hello Nancy World";
        }
    }
}