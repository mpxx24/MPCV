using System;
using System.Linq;
using MPCV.DatabaseAccess;

namespace MPCV.DataAccessTests {
    internal class Program {
        private static void Main(string[] args) {
            using (var ctx = new UserContext()) {
                var user = ctx.Users.First();
                AddProgrammingSkill(user);
                ctx.SaveChanges();
            }
        }

        private static User AddUser(UserContext ctx) {
            var user = new User
            {
                FirstName = "Mariusz",
                LastName = "Piątkowski",
                Birthdate = new DateTime(1991, 3, 1).Date,
                CurrentAddress = "Gdańsk, ul. Przytulna 26/33",
                EmailAddress = "mpxx24@gmail.com",
                Id = Guid.NewGuid(),
                PhoneNumber = "889121662",
                PlaceOfBirth = "Miastko"
            };

            var pskill = new ProgrammingSkill
            {
                SkillLevel = 7,
                SkillName = "C#"
            };

            user.ProgrammingSkills.Add(pskill);

            ctx.Users.Add(user);
            ctx.SaveChanges();
            return user;
        }

        private static void AddProgrammingSkill(User user) {
            var pSkill1 = new ProgrammingSkill
            {
                SkillName = "JavaScript",
                SkillLevel = 4
            };
            user.ProgrammingSkills.Add(pSkill1);
        }
    }
}