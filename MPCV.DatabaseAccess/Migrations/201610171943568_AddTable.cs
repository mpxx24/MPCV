using System.Data.Entity.Migrations;

namespace MPCV.DatabaseAccess.Migrations {
    public partial class AddTable : DbMigration {
        public override void Up() {
            CreateTable(
                "dbo.Activities",
                c => new
                {
                    Id = c.Int(false, true),
                    From = c.DateTime(false),
                    To = c.DateTime(false),
                    Description = c.String(),
                    Category = c.Int(false),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
        }

        public override void Down() {
            DropForeignKey("dbo.ProgrammingSkills", "UserId", "dbo.Users");
            DropForeignKey("dbo.Activities", "User_Id", "dbo.Users");
            DropIndex("dbo.ProgrammingSkills", new[] {"UserId"});
            DropIndex("dbo.Activities", new[] {"User_Id"});
            DropTable("dbo.Users");
            DropTable("dbo.ProgrammingSkills");
            DropTable("dbo.Posts");
            DropTable("dbo.Activities");
        }
    }
}