using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaseMVC.Startup))]
namespace BaseMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
