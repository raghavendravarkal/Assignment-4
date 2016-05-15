using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentInfoMVCApp.Startup))]
namespace StudentInfoMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
