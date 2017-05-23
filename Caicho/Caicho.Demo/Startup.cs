using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Caicho.Demo.Startup))]
namespace Caicho.Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
