using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RGNCompensation.Startup))]
namespace RGNCompensation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
