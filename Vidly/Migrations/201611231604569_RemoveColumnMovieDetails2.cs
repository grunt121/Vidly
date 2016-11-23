namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveColumnMovieDetails2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movies", new[] { "MovieDetail_Id1" });
            DropColumn("dbo.Movies", "MovieDetail_Id");
            RenameColumn(table: "dbo.Movies", name: "MovieDetail_Id1", newName: "MovieDetail_Id");
            AlterColumn("dbo.Movies", "MovieDetail_Id", c => c.Int());
            CreateIndex("dbo.Movies", "MovieDetail_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Movies", new[] { "MovieDetail_Id" });
            AlterColumn("dbo.Movies", "MovieDetail_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Movies", name: "MovieDetail_Id", newName: "MovieDetail_Id1");
            AddColumn("dbo.Movies", "MovieDetail_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "MovieDetail_Id1");
        }
    }
}
