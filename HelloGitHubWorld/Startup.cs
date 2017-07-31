using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloGitHubWorld.Startup))]
namespace HelloGitHubWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
