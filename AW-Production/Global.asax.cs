using System.Web.Http;
using System.Web.Mvc;

namespace AW_Production
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configure(SwaggerConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            LoggerConfig.Register();
        }
    }
}
