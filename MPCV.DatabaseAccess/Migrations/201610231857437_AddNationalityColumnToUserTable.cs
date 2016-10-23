using System.Data.Entity.Migrations;

namespace MPCV.DatabaseAccess.Migrations {
    public partial class AddNationalityColumnToUserTable : DbMigration {
        public override void Up() {
            AddColumn("dbo.Users", "Nationality", c => c.String());
        }

        public override void Down() {
            DropColumn("dbo.Users", "Nationality");
        }
    }
}