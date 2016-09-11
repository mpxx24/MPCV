using System;
using System.Collections.Generic;

namespace MPCV.Models.ApiModels {
    public class UserApiModel {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string EmailAddress { get; set; }

        public ICollection<ProgrammingSkillApiModel> ProgrammingSkills { get; set; }
    }
}