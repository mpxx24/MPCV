using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MPCV.DatabaseAccess {
    /// <summary>
    ///     User class
    /// </summary>
    public class User {
        /// <summary>
        ///     Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User() {
            // ReSharper disable once VirtualMemberCallInContructor
            ProgrammingSkills = new List<ProgrammingSkill>();
        }

        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string PlaceOfBirth { get; set; }
        public string CurrentAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<ProgrammingSkill> ProgrammingSkills { get; set; }
    }
}