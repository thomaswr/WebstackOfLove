using System.Web.Http;
using System.Web.Routing;

namespace WebstackOfLove
{
    public static class WebApiConfig
    {
        public static void Initialize(HttpConfiguration config)
        {
			// Register the default hubs route: ~/signalr
			RouteTable.Routes.MapHubs();

            config.Routes.MapHttpRoute(
                "apiRoute",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional }
            );
        }
    }
}