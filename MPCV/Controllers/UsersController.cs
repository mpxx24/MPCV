using System.Collections.Generic;
using System.Web.Http;
using MPCV.Models.ApiModels;
using MPCV.Services.Interfaces;

namespace MPCV.Controllers {
    public class UsersController : ApiController {
        private readonly IUserService userService;
        
        public UsersController(IUserService userService) {
            this.userService = userService;
        }

        // GET api/users
        public IEnumerable<UserApiModel> Get() {
            return this.userService.GetWebApiUserResults();
        }
    }
}