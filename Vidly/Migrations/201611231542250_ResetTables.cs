namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResetTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "MovieDetail_Id", "dbo.MovieDetails");
            DropIndex("dbo.Movies", new[] { "MovieDetail_Id" });
            AddColumn("dbo.Movies", "MovieDetail_Id1", c => c.Int());
            AlterColumn("dbo.Movies", "MovieDetail_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "MovieDetail_Id1");
            AddForeignKey("dbo.Movies", "MovieDetail_Id1", "dbo.MovieDetails", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieDetail_Id1", "dbo.MovieDetails");
            DropIndex("dbo.Movies", new[] { "MovieDetail_Id1" });
            AlterColumn("dbo.Movies", "MovieDetail_Id", c => c.Int());
            DropColumn("dbo.Movies", "MovieDetail_Id1");
            CreateIndex("dbo.Movies", "MovieDetail_Id");
            AddForeignKey("dbo.Movies", "MovieDetail_Id", "dbo.MovieDetails", "Id");
        }
    }
}
