using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MPCV.DatabaseAccess;
using MPCV.Models.ApiModels;
using MPCV.Models.Converters;
using MPCV.Services.Interfaces;

namespace MPCV.Services {
    public class UserWebApiService : IUserWebApiService {
        public IEnumerable<UserApiModel> GetWebApiUserResults() {
            using (var ctx = new UserContext()) {
                ctx.Configuration.ProxyCreationEnabled = false;
                var users = UserModelConverter.ConvertUserToApiModel(ctx.Users.Include(x => x.ProgrammingSkills).First());

                return users;
            }
        }
    }
}