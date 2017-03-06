using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(build_test_mvc.Startup))]
namespace build_test_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
