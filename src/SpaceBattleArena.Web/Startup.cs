using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpaceBattleArena.Web.Startup))]
namespace SpaceBattleArena.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
