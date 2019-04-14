using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AirPort_MVC.Startup))]
namespace AirPort_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
