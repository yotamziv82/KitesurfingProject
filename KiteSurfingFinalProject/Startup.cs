using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KiteSurfingFinalProject.Startup))]
namespace KiteSurfingFinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
