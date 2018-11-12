using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(INC.Web.MVC.Framework.Sample.Startup))]
namespace INC.Web.MVC.Framework.Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
