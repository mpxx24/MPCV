using System.Linq;
using Castle.Core.Internal;
using Castle.Windsor;
using MPCV.Services.Installers;
using MPCV.Services.Interfaces;
using NUnit.Framework;

namespace MPCV.Tests {
    [TestFixture]
    public class ServicesInstallerTests {
        private IWindsorContainer container;

        [SetUp]
        public void SetUp() {
            this.container = new WindsorContainer().Install(new ServicesInstaller());
        }

        [Test]
        public void AllServices_Registered_Implement_IBaseService() {
            var registeredServices = TestHelper.GetImplementationTypes(typeof (object), this.container);

            Assert.That(registeredServices.All(x => x.Is<IBaseService>()));
        }

        [Test]
        public void AllServices_Registered_True() {
            var services = TestHelper.GetAllPublicClassesOfThisTypeFromAssembly(typeof (IBaseService), x => x.Is<IBaseService>());
            var registeredServices = TestHelper.GetImplementationTypes(typeof (IBaseService), this.container);

            Assert.AreEqual(services, registeredServices);
        }

        [Test]
        public void AllServices_Naming_EndsWith_Service() {
            var services = TestHelper.GetImplementationTypes(typeof (object), this.container);

            Assert.That(services.All(x => x.Name.EndsWith("Service")));
        }
    }
}