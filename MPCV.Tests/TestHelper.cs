using System;
using System.Collections.Generic;
using System.Linq;
using Castle.MicroKernel;
using Castle.Windsor;

namespace MPCV.Tests {
    public class TestHelper {
        public static IEnumerable<Type> GetAllPublicClassesOfThisTypeFromAssembly(Type type, Predicate<Type> predicate) {
            return type.Assembly.GetExportedTypes()
                .Where(x => x.IsClass)
                .Where(predicate.Invoke)
                .OrderBy(x => x.Name)
                .ToList();
        }

        public static IEnumerable<Type> GetImplementationTypes(Type type, IWindsorContainer container) {
            return GetHandlersFor(type, container)
                .Select(x => x.ComponentModel.Implementation)
                .OrderBy(x => x.Name)
                .ToList();
        }

        private static IEnumerable<IHandler> GetHandlersFor(Type type, IWindsorContainer container) {
            return container.Kernel.GetAssignableHandlers(type);
        }
    }
}