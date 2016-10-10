using System;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.Windsor;

namespace MPCV.Services.Windsor {
    public class WindsorMvcControllerFactory : DefaultControllerFactory {
        public WindsorMvcControllerFactory(IWindsorContainer container) {
            if (container == null) {
                throw new ArgumentNullException(nameof(container));
            }
            this.container = container;
        }

        public IWindsorContainer container { get; protected set; }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType) {
            if (controllerType == null) {
                return null;
            }
            return container.Resolve(controllerType) as IController;
        }

        public override void ReleaseController(IController controller) {
            var disposableController = controller as IDisposable;
            disposableController?.Dispose();

            container.Release(controller);
        }
    }
}