using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstokMaster.Startup))]
namespace EstokMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
