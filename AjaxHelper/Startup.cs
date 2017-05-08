using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxHelper.Startup))]
namespace AjaxHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
