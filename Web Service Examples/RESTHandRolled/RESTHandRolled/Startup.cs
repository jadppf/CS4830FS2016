using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RESTHandRolled.Startup))]
namespace RESTHandRolled
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
