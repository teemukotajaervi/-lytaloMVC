using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ÄlytaloMVC.Startup))]
namespace ÄlytaloMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
