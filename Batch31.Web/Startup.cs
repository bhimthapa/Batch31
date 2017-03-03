using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Batch31.Web.Startup))]
namespace Batch31.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
