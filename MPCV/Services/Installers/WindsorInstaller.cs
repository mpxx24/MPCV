using System.Web.Http.Controllers;
using System.Web.Mvc;
using Castle.Facilities.Logging;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MPCV.Repository;
using MPCV.Services.Interfaces;

namespace MPCV.Services.Installers {
    public class WindsorInstaller : IWindsorInstaller {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            container.Register(
                Classes.FromThisAssembly().BasedOn<IHttpController>().LifestylePerWebRequest(),
                Classes.FromThisAssembly().BasedOn<IController>().LifestylePerWebRequest()
                );

            container.Register(
                Component.For<IRepository>().ImplementedBy<Repository.Repository>(),
                Component.For<IUserService>().ImplementedBy<UserService>(),
                Component.For<IBlogService>().ImplementedBy<BlogService>()
                );

            container.AddFacility<LoggingFacility>(x => x.LogUsing(LoggerImplementation.NLog).WithConfig("NLog.config"));
        }
    }
}