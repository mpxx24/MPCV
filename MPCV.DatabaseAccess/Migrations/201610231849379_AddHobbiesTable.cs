using System.Data.Entity.Migrations;

namespace MPCV.DatabaseAccess.Migrations {
    public partial class AddHobbiesTable : DbMigration {
        public override void Up() {
            CreateTable(
                "dbo.Hobbies",
                c => new
                {
                    Id = c.Int(false, true),
                    Name = c.String(),
                    IsSport = c.Boolean(false),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
        }

        public override void Down() {
            DropForeignKey("dbo.Hobbies", "User_Id", "dbo.Users");
            DropIndex("dbo.Hobbies", new[] {"User_Id"});
            DropTable("dbo.Hobbies");
        }
    }
}