using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using MPCV.DatabaseAccess;
using MPCV.Models.ApiModels;
using static MPCV.Models.Converters.UserModelConverter;

namespace MPCV.Controllers {
    public class UsersController : ApiController {
        // GET api/users
        public IEnumerable<UserApiModel> Get() {
            using (var ctx = new UserContext()) {
                ctx.Configuration.ProxyCreationEnabled = false;
                var users = ConvertUserToApiModel(ctx.Users.Include(x => x.ProgrammingSkills).First());

                return users;
            }
        }
    }
}
