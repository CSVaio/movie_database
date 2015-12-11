using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Database_Application.Startup))]
namespace Database_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
