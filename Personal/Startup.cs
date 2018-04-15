using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Personal.Startup))]
namespace Personal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
