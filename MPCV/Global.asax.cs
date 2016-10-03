using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using Castle.Windsor.Installer;
using MPCV.Services.Installers;

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
            container = new WindsorContainer();
            container.Install(FromAssembly.This());
            container.Install(new WindsorInstaller());
            container.Kernel.Resolver.AddSubResolver(new CollectionResolver(container.Kernel, true));
        }
    }
}