using System.Data.Entity.Migrations;

namespace MPCV.DatabaseAccess.Migrations {
    public partial class addedcomments : DbMigration {
        public override void Up() {
            CreateTable(
                "dbo.Comments",
                c => new
                {
                    Id = c.Int(false, true),
                    Text = c.String(),
                    Added = c.DateTime(false),
                    Author = c.String(),
                    Post_Id = c.Int()
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.Post_Id)
                .Index(t => t.Post_Id);
        }

        public override void Down() {
            DropForeignKey("dbo.Comments", "Post_Id", "dbo.Posts");
            DropIndex("dbo.Comments", new[] {"Post_Id"});
            DropTable("dbo.Comments");
        }
    }
}