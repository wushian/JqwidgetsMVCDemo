using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JqwidgetsMVCDemo.Startup))]
namespace JqwidgetsMVCDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
