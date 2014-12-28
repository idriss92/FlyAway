using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlyAway.Startup))]
namespace FlyAway
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
