using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppDev_FST.Startup))]
namespace AppDev_FST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
