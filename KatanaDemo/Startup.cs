// Katana Demo
// Mike Dice (mikedice417@hotmail.com)
// Created: March 2014.

using System.Web.Http;
using Owin;

namespace KatanaDemo
{
    // Start up a service using the Nancy framework
    public class StartupNancy
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
    
    // Start up a service using Microsoft System.Web MVC framework.
    public class StartupSystemWeb
    {
        public void Configuration(IAppBuilder app)
        {
            //app.UseNancy();
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "Default",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional });

            app.UseWebApi(config);
        }
    }

    /// <summary>
    /// This controller is used when we're demo'ing System.Web.Http hosting
    /// </summary>
    public class TestController : ApiController
    {
        [HttpGet]
        public string[] Data()
        {
            return new string[] {"This", "Is", "Neat"};
        }

    }
}