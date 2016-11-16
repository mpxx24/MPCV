using System;
using System.Data.Entity.Migrations;
using System.Linq;
using MPCV.DatabaseAccess.Blog;
using MPCV.DatabaseAccess.User;

namespace MPCV.DatabaseAccess.Migrations {
    internal sealed class Configuration : DbMigrationsConfiguration<AppContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppContext context) {
            //var user = context.Users.First();
            //context.Hobbies.AddOrUpdate(new Hobby
            //{
            //    Name = "Muzyka",
            //    IsSport = false,
            //    User = user
            //});
        }
    }
}