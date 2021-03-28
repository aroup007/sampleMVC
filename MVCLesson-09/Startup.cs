using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLesson_09.Startup))]
namespace MVCLesson_09
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
