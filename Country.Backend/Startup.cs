using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Country.Backend.Startup))]
namespace Country.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
