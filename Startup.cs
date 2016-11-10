using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CorporeWebPortal.Startup))]
namespace CorporeWebPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
