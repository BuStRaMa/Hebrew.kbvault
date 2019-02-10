namespace KBVault.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastAuthorEdited2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Article", "Author");
            RenameColumn(table: "dbo.Article", name: "LastAuthorEdited", newName: "Author");
            RenameIndex(table: "dbo.Article", name: "IX_LastAuthorEdited", newName: "IX_Author");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Article", name: "IX_Author", newName: "IX_LastAuthorEdited");
            RenameColumn(table: "dbo.Article", name: "Author", newName: "LastAuthorEdited");
            AddColumn("dbo.Article", "Author", c => c.Long(nullable: false));
        }
    }
}
