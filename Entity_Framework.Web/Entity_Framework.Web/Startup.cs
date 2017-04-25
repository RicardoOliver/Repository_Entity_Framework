using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Entity_Framework.Web.Startup))]
namespace Entity_Framework.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
