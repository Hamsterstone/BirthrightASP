using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BirthrightASP.Startup))]
namespace BirthrightASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
