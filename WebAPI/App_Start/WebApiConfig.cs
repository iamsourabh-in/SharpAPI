using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.ActionFilters;
using WebAPI.Handlers;

namespace WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var corsAttr = new EnableCorsAttribute("http://localhost:4200", "*", "*");
            config.EnableCors(corsAttr);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Filters.Add(new LoggingFilterAttribute());
            config.MessageHandlers.Add(new WrappingHandler()); // <- comment this line to enable swagger
        }

    }
}
