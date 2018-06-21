using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TESTWEBSITE.Startup))]
namespace TESTWEBSITE
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
