using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Todolistapp.Startup))]
namespace Todolistapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
