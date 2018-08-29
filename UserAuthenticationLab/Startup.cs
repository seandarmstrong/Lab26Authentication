using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserAuthenticationLab.Startup))]
namespace UserAuthenticationLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
