using System.Configuration;
using System.Web.Http;
using Thinktecture.IdentityModel.Http.Cors.WebApi;

namespace WebApi
{
    public class CorsConfig
    {
        public static void RegisterCors(HttpConfiguration httpConfig)
        {
            var corsConfig = new WebApiCorsConfiguration();
            corsConfig.RegisterGlobal(httpConfig);
            corsConfig.ForAll().AllowAll();
                //.ForResources(ConfigurationManager.AppSettings["CORS_RESOURCES"].Split(';'))
                //.ForOrigins(ConfigurationManager.AppSettings["CORS_ORIGINS"].Split(';'))
                //.AllowAllRequestHeaders()
                //.AllowMethods("GET", "POST");

            var corsHandler = new CorsMessageHandler(corsConfig, httpConfig);
            httpConfig.MessageHandlers.Add(corsHandler);
        }
    }
}
