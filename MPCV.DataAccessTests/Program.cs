using System;
using System.Linq;
using MPCV.DatabaseAccess;
using MPCV.DatabaseAccess.Blog;

namespace MPCV.DataAccessTests {
    internal class Program {
        private static void Main(string[] args) {
            using (var ctx = new AppContext()) {
                AddUser(ctx);
                var user = ctx.Users.First();
                AddProgrammingSkill(user);
                ctx.SaveChanges();
                AddBlogPost(ctx);
            }
        }

        private static User AddUser(AppContext ctx) {
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

        private static void AddBlogPost(AppContext ctx) {
            var content = "<div class=\"code\">" +
                           "<span class=\"class\">public class</span> UserWebApiService : IUserWebApiService { " +
                                "<span class=\"method\">public IEnumerable</span><UserApiModel> GetWebApiUserResults() {" +
                                    "using (var ctx = new AppContext()) {" +
                                        "ctx.Configuration.ProxyCreationEnabled = false;" +
                                        "<span class\"type\">var</span> users = UserModelConverter.ConvertUserToApiModel(ctx.Users.Include(x => x.ProgrammingSkills).First());" +
                                        "return users;" +
                                        "}" +
                                    "}" +
                                "}" +
                           "</div>";
            var post = new Post
            {
                Added = DateTime.Today.Date,
                Author = "Mariusz Piątkowski",
                Category = PostCategory.Csharp,
                Content = content,
                ShortDescription = "well... the first problem with Web API",
                Title = "web api - displaying user with his programming skills"
            };
            ctx.Posts.Add(post);
            ctx.SaveChanges();
        }
    }
}