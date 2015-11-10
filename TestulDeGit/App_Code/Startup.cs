using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestulDeGit.Startup))]
namespace TestulDeGit
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
