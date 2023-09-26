using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ABC_University.Startup))]
namespace ABC_University
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
