using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(consumeWebAPI.Startup))]
namespace consumeWebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
