using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NeedMe.Startup))]
namespace NeedMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
