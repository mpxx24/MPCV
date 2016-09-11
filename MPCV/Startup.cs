using Microsoft.Owin;
using MPCV;
using Owin;

[assembly: OwinStartup(typeof (Startup))]
namespace MPCV {
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}