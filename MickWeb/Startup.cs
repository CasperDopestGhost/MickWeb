using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MickWeb.Startup))]
namespace MickWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
