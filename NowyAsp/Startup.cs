using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NowyAsp.Startup))]
namespace NowyAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
