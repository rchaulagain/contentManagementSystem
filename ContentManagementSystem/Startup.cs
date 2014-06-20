using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContentManagementSystem.Startup))]
namespace ContentManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
