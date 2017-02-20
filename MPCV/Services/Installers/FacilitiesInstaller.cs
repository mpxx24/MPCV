using Castle.Facilities.Logging;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace MPCV.Services.Installers {
    public class FacilitiesInstaller : IWindsorInstaller {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            container.AddFacility<LoggingFacility>(x => x.LogUsing(LoggerImplementation.NLog).WithConfig("NLog.config"));
        }
    }
}