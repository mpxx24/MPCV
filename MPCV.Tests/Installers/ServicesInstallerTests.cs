﻿using System.Linq;
using System.Reflection;
using Castle.Core.Internal;
using Castle.Windsor;
using MPCV.Services.Installers;
using MPCV.Services.Interfaces;
using NUnit.Framework;

namespace MPCV.Tests.Installers {
    [TestFixture]
    public class ServicesInstallerTests {
        private IWindsorContainer container;

        [SetUp]
        public void SetUp() {
            this.container = new WindsorContainer().Install(new ServicesInstaller());
        }

        [Test]
        public void AllServices_Naming_EndsWith_Service() {
            var services = TestHelper.GetImplementationTypes(typeof (object), this.container);

            Assert.That(services.All(x => x.Name.EndsWith("Service")));
        }

        [Test]
        public void AllServices_Naming_MethodNamesStartWithCapitalLetter() {
            var allServices = TestHelper.GetAllPublicClassesOfThisTypeFromAssembly(typeof(IBaseService), x => x.Is<IBaseService>());
            var allMethodsFromServices = allServices.SelectMany(x => x.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance));

            foreach (var method in allMethodsFromServices) {
                Assert.That(char.IsUpper(method.Name[0]));
            }
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
    }
}