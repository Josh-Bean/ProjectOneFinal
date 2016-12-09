//Joshua Bean, Section 2, Group 14, Last Modified: December 8th, 2016, BYU IS FAQ Page
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
