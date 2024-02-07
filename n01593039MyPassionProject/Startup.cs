using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(n01593039MyPassionProject.Startup))]
namespace n01593039MyPassionProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
