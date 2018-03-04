using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC2_Market.Startup))]
namespace MVC2_Market
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
