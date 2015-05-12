using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAGS.Startup))]
namespace SAGS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
