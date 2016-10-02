using System.Collections.Generic;
using System.Web.Http;
using MPCV.Models.ApiModels;
using MPCV.Services.Interfaces;

namespace MPCV.Controllers {
    public class UsersController : ApiController {
        private readonly IUserWebApiService userWebApiService;

        public UsersController(IUserWebApiService userWebApiService) {
            this.userWebApiService = userWebApiService;
        }

        // GET api/users
        public IEnumerable<UserApiModel> Get() {
            return userWebApiService.GetWebApiUserResults();
        }
    }
}