using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IsdWebSiteApp.Startup))]
namespace IsdWebSiteApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
