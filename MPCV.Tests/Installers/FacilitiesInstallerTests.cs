using Castle.Windsor;
using MPCV.Services.Installers;
using NUnit.Framework;

namespace MPCV.Tests.Installers {
    [TestFixture]
    public class FacilitiesInstallerTests {
        private IWindsorContainer container;

        [SetUp]
        public void SetUp() {
            this.container = new WindsorContainer().Install(new FacilitiesInstaller());
        }

        [Ignore("Need to resolve problem with type conversion exception")]
        [Test]
        public void AllFacilities_Registered_True() {
            //TODO: exception is thrown (type conversion?)
            var facilities = this.container.Kernel.GetFacilities();
            Assert.That(facilities.Length, Is.EqualTo(1));
        }
    }
}