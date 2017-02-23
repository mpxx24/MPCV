using Castle.Windsor;
using MPCV.Services.Installers;
using NUnit.Framework;

namespace MPCV.Tests.Installers {
    [TestFixture]
    public class FacilitiesInstallerTests {
        private IWindsorContainer container;

        [SetUp]
        public void SetUp() {
            container = new WindsorContainer().Install(new FacilitiesInstaller());
        }

        [Ignore("Need to resolve problem with type conversion exception")]
        [Test]
        public void AllFacilities_Registered_True() {
            //TODO: exception is thrown (type converstion?)
            var facilities = container.Kernel.GetFacilities();
            Assert.That(facilities.Length, Is.EqualTo(1));
        }
    }
}