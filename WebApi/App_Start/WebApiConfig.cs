using System.Configuration;
using System.Web.Http;

namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MessageHandlers.Add(new WebApi.App_Start.JsonWebTokenValidationHandler()
            {
                Audience = ConfigurationManager.AppSettings["AUTH0_CLIENT_ID"],
                SymmetricKey = ConfigurationManager.AppSettings["AUTH0_CLIENT_SECRET"]
            });   

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }

    
}
