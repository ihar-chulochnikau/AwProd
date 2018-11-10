using AW_Production.Filters;
using Swashbuckle.Application;
using System;
using System.Web.Http;

namespace AW_Production
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config
             .EnableSwagger(
                c =>
                {
                    c.SingleApiVersion("v1", "Production Products");
                    c.IncludeXmlComments(GetXmlCommentsPath());
                    c.UseFullTypeNameInSchemaIds();
                    c.SchemaFilter<ProductFilter>();
                })
             .EnableSwaggerUi();
            
        }

        protected static string GetXmlCommentsPath()
        {
            return string.Format(@"{0}\bin\AW-Production.xml", AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
