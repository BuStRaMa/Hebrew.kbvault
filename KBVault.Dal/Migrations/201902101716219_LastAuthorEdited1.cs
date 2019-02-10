namespace KBVault.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastAuthorEdited1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Article", "LastAuthorEdited");
            RenameColumn(table: "dbo.Article", name: "Author", newName: "LastAuthorEdited");
            RenameIndex(table: "dbo.Article", name: "IX_Author", newName: "IX_LastAuthorEdited");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Article", name: "IX_LastAuthorEdited", newName: "IX_Author");
            RenameColumn(table: "dbo.Article", name: "LastAuthorEdited", newName: "Author");
            AddColumn("dbo.Article", "LastAuthorEdited", c => c.Long(nullable: false));
        }
    }
}
