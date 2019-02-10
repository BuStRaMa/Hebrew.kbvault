namespace KBVault.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedSefName : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Article", "SefName");
            DropColumn("dbo.Category", "SefName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Category", "SefName", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AddColumn("dbo.Article", "SefName", c => c.String(nullable: false, maxLength: 200, unicode: false));
        }
    }
}
