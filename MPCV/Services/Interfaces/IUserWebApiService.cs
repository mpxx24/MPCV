using System.Collections.Generic;
using MPCV.Models.ApiModels;

namespace MPCV.Services.Interfaces {
    public interface IUserWebApiService {
        /// <summary>
        /// Gets the web API user results.
        /// </summary>
        /// <returns>list of UserApiModel</returns>
        IEnumerable<UserApiModel> GetWebApiUserResults();
    }
}