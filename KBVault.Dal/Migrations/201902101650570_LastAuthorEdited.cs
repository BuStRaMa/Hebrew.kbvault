namespace KBVault.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastAuthorEdited : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Article", "LastAuthorEdited", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Article", "LastAuthorEdited");
        }
    }
}
