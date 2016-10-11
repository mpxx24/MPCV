using System.Collections.Generic;
using System.Linq;
using MPCV.DatabaseAccess;
using MPCV.Models.ApiModels;
using MPCV.Models.Converters;
using MPCV.Repository;
using MPCV.Services.Interfaces;

namespace MPCV.Services {
    public class UserWebApiService : IUserWebApiService {
        private readonly IRepository repository;

        public UserWebApiService(IRepository repository) {
            this.repository = repository;
        }

        public IEnumerable<UserApiModel> GetWebApiUserResults() {
            //do not use repository.GetFirst() here - this way I don't have to specify user id in code
            var users = repository.GetAll<User>();

            return UserModelConverter.ConvertUserToApiModel(users.First());
        }
    }
}