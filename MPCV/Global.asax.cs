using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.Windsor;
using Castle.Windsor.Installer;
using MPCV.Services.Installers;
using MPCV.Windsor;

namespace MPCV {
    public class WebApiApplication : HttpApplication {
        private IWindsorContainer container;

        public WebApiApplication() {
        }

        public WebApiApplication(IWindsorContainer container) {
            this.container = container;
        }

        public override void Dispose() {
            container.Dispose();
            base.Dispose();
        }

        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //windsor magic
            container = new WindsorContainer().Install(new ServicesInstaller());
            container.Install(FromAssembly.This());
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), new WindsorCompositionRoot(container));
        }
    }
}