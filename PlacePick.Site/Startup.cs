using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlacePick.Site.Startup))]
namespace PlacePick.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
