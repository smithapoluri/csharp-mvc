using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpaApp.Startup))]
namespace SpaApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
