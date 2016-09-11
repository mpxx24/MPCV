using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using MPCV.DatabaseAccess;

namespace MPCV.Controllers {
    public class UsersController : ApiController {
        // GET api/values
        public IEnumerable<User> Get() {
            using (var ctx = new UserContext()) {
                ctx.Configuration.ProxyCreationEnabled = false;
                return ctx.Users.Include(c => c.ProgrammingSkills).ToList();
            }
        }
    }
}
