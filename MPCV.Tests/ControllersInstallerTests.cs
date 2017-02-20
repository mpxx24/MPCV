using System.Web.Http.Controllers;
using System.Web.Mvc;
using Castle.Core.Internal;
using Castle.Windsor;
using MPCV.Controllers;
using MPCV.Services.Installers;
using NUnit.Framework;

namespace MPCV.Tests {
    [TestFixture]
    public class ControllersInstallerTests {
        private IWindsorContainer container;

        [SetUp]
        public void SetUp() {
            this.container = new WindsorContainer().Install(new ControllersInstaller());
        }

        [Test]
        public void AllControllers_Mvc_Registered_True() {
            var allMvcControllers = TestHelper.GetAllPublicClassesOfThisTypeFromAssembly(typeof (HomeController), x => x.Is<IController>());
            var allRegisteredMvcControllers = TestHelper.GetImplementationTypes(typeof (IController), this.container);

            Assert.AreEqual(allMvcControllers, allRegisteredMvcControllers);
        }

        [Test]
        public void AllControllers_WebApi_Registered_True() {
            var allWebApiControllers = TestHelper.GetAllPublicClassesOfThisTypeFromAssembly(typeof (UsersController), x => x.Is<IHttpController>());
            var allRegisteredWebApiControllers = TestHelper.GetImplementationTypes(typeof (IHttpController), this.container);

            Assert.AreEqual(allWebApiControllers, allRegisteredWebApiControllers);
        }
    }
}