using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcIntro.Startup))]
namespace mvcIntro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
