namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieDetails : DbMigration
    {
        public override void Up()


        {
            Sql("INSERT INTO MovieDetails (ReleaseDate, DateAdded, NumberInStock) VALUES (23/11/2015,23/11/2014,24)");
        }
        
        public override void Down()
        {
        }
    }
}
