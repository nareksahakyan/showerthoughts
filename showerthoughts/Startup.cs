using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(showerthoughts.Startup))]
namespace showerthoughts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
