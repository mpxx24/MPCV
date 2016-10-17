using System.Collections.Generic;
using System.Linq;
using MPCV.DatabaseAccess.User;
using MPCV.Models.ApiModels;

namespace MPCV.Models.Converters {
    public static class UserModelConverter {
        public static ICollection<UserApiModel> ConvertUserToApiModel(User user) {
            var result = new List<UserApiModel>
            {
                new UserApiModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Birthdate = user.Birthdate,
                    EmailAddress = user.EmailAddress,
                    ProgrammingSkills = ConvertProgrammingSkillsToApiModel(user.ProgrammingSkills)
                }
            };


            return result;
        }

        private static ICollection<ProgrammingSkillApiModel> ConvertProgrammingSkillsToApiModel(ICollection<ProgrammingSkill> skills) {
            return skills.Select(programmingSkill => new ProgrammingSkillApiModel
            {
                SkillName = programmingSkill.SkillName,
                SkillLevel = programmingSkill.SkillLevel
            }).ToList();
        }
    }
}