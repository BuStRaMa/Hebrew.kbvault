namespace KBVault.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LockSite : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "LockSite", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "LockSite");
        }
    }
}
