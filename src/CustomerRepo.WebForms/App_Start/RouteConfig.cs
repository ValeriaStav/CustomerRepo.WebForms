using Microsoft.AspNet.FriendlyUrls;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace CustomerRepo.WebForms
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
        }
    }
}
