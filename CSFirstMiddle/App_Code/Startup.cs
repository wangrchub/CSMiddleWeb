using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSFirstMiddle.Startup))]
namespace CSFirstMiddle
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
