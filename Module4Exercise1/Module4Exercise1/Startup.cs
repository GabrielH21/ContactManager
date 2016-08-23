using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Module4Exercise1.Startup))]
namespace Module4Exercise1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
