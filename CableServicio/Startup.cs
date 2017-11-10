using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CableServicio.Startup))]
namespace CableServicio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
