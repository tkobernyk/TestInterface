using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using TestInterface.Resolver;

namespace TestInterface.Config
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling =
                Newtonsoft.Json.PreserveReferencesHandling.Objects;

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(
                new QueryStringMapping("type", "json", new MediaTypeHeaderValue("application/json")));
            
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.WriterSettings.OmitXmlDeclaration = false;

            GlobalConfiguration.Configuration.Formatters.XmlFormatter.MediaTypeMappings.Add(
                new QueryStringMapping("type", "xml", new MediaTypeHeaderValue("application/xml")));

            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            DynamicAssemblyResolver assemblyResolver = new DynamicAssemblyResolver();
            config.Services.Replace(typeof(IAssembliesResolver), assemblyResolver);
        }

    }
}