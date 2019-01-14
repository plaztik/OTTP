using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OTTP.Startup))]
namespace OTTP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
