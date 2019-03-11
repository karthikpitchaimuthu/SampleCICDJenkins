using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleCICDApp.Startup))]
namespace SampleCICDApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
