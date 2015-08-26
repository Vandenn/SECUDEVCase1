using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SECUDEVCase1.Startup))]
namespace SECUDEVCase1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
