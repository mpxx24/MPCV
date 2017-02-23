using Castle.Core.Internal;
using Castle.Windsor;
using MPCV.Repository;
using MPCV.Services.Installers;
using NUnit.Framework;

namespace MPCV.Tests.Installers {
    [TestFixture]
    public class RepositoryInstallerTests {
        private IWindsorContainer container;

        [SetUp]
        public void SetUp() {
            this.container = new WindsorContainer().Install(new RepositoryInstaller());
        }

        [Test]
        public void Repository_Registered_True() {
            var repository = TestHelper.GetAllPublicClassesOfThisTypeFromAssembly(typeof(IRepository), x => x.Is<IRepository>());
            var registeredRepositories = TestHelper.GetImplementationTypes(typeof(IRepository), container);

            Assert.AreEqual(repository, registeredRepositories);
        }
    }
}