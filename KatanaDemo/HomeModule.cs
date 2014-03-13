using Nancy;

namespace WebApplication2
{
    public class HomeModule : NancyModule
    {
        /// <summary>
        /// Home Module constructor
        /// In Nancy, routes are defined in the constructor of the module.
        /// A route is defined by httpMethod + pattern + action
        /// </summary>
        public HomeModule()
        {
            // Define the default route '/'
            // HTTP Action = GET
            // URL Pattern = '/'
            // Action is defined by the lambda expression below.
            Get["/"] = (a) =>
            {
                // create a model for the view and return the view. Home.html is rendered.
                var model = new { title = "Wow. Interesting syntax Nancy." };
                return View["home", model];
            };
        }
    }
}