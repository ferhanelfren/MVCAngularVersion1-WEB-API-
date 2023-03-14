using System.Web.Http;
using WebActivatorEx;
using MVCAngularVersion1;
using Swashbuckle.Application;
using System.Reflection.Emit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace MVCAngularVersion1
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "MVCAngularVersion1");
                    })
                .EnableSwaggerUi();
        }

    }
}
