using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScoreboardVB15.Startup))]
namespace ScoreboardVB15
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
