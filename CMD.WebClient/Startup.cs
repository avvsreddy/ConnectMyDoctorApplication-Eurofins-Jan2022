using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CMD.WebClient.Startup))]
namespace CMD.WebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
