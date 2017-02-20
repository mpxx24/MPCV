using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MPCV.Services.Interfaces;

namespace MPCV.Services.Installers {
    public class ServicesInstaller : IWindsorInstaller {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            container.Register(
                Component.For<IUserService>().ImplementedBy<UserService>(),
                Component.For<IBlogService>().ImplementedBy<BlogService>()
                );
        }
    }
}