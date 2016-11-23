namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMoviesGenreId1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String());
            DropColumn("dbo.Movies", "GenreId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.String());
            DropColumn("dbo.Movies", "Genre");
        }
    }
}
