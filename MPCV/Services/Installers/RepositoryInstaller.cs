using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MPCV.Repository;

namespace MPCV.Services.Installers {
    public class RepositoryInstaller : IWindsorInstaller {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            container.Register(
                Component.For<IRepository>().ImplementedBy<Repository.Repository>()
            );
        }
    }
}