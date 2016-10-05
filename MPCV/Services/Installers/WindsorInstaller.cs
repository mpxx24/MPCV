using System.Web.Http;
using System.Web.Http.Controllers;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MPCV.Services.Interfaces;

namespace MPCV.Services.Installers {
    public class WindsorInstaller : IWindsorInstaller {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            container.Register(
                Classes.FromThisAssembly().BasedOn<IHttpController>().LifestylePerWebRequest()
                );

            container.Register(
                Component.For<IUserWebApiService>().ImplementedBy<UserWebApiService>()
                );
        }
    }
}