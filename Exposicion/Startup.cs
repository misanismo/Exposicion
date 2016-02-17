using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exposicion.Startup))]
namespace Exposicion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
