using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ventas.API.Startup))]
namespace Ventas.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
