using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocalMe.Startup))]
namespace LocalMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
