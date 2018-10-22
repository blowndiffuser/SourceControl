using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SourceControl.Startup))]
namespace SourceControl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
