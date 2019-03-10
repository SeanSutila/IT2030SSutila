using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week8LogIn.Startup))]
namespace Week8LogIn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
