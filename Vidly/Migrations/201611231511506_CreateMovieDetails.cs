namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMovieDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReleaseDate = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        NumberInStock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "MovieDetail_Id", c => c.Int());
            CreateIndex("dbo.Movies", "MovieDetail_Id");
            AddForeignKey("dbo.Movies", "MovieDetail_Id", "dbo.MovieDetails", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieDetail_Id", "dbo.MovieDetails");
            DropIndex("dbo.Movies", new[] { "MovieDetail_Id" });
            DropColumn("dbo.Movies", "MovieDetail_Id");
            DropTable("dbo.MovieDetails");
        }
    }
}
