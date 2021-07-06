using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DCXEMAY.Startup))]
namespace DCXEMAY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
