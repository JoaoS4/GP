using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GP.Startup))]
namespace GP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
