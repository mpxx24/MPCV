using System.Web.Mvc;
using MPCV.Models.Assistant;

namespace MPCV.Controllers {
    public class AssistantController : Controller {
        public string GetAssistantInfo() {
            return AssistantTempLocalization.GetInformations();
        }
    }
}