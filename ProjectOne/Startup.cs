using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectOne.Startup))]
namespace ProjectOne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
