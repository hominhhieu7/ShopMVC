using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MCVWithSotre.Startup))]
namespace MCVWithSotre
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
