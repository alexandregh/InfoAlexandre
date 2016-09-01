using System.Web.Http;
using InfoAlexandre.WebApi.AutoMapper.AutoMapperConfigs;

namespace InfoAlexandre.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.Register();
        }
    }
}
