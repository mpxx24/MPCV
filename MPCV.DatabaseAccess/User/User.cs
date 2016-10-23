using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MPCV.DatabaseAccess.User {
    /// <summary>
    ///     User class
    /// </summary>
    public class User {
        /// <summary>
        ///     Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User() {
            ProgrammingSkills = new List<ProgrammingSkill>();
            Activities = new List<Activity>();
        }

        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Nationality { get; set; }
        public string PlaceOfBirth { get; set; }
        public string CurrentAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<ProgrammingSkill> ProgrammingSkills { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Language> Languages { get; set; }
        public virtual ICollection<Hobby> Hobbies { get; set; }
    }
}