using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pamoka1.Startup))]
namespace Pamoka1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
