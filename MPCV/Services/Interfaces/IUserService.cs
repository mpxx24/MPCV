using System.Collections.Generic;
using MPCV.DatabaseAccess.User;
using MPCV.Models.ApiModels;

namespace MPCV.Services.Interfaces {
    public interface IUserService {
        /// <summary>
        /// Gets the web API user results.
        /// </summary>
        /// <returns>list of UserApiModel</returns>
        IEnumerable<UserApiModel> GetWebApiUserResults();

        User GetFirstUser();
    }
}