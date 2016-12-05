namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenereTable : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Genres ( Id,GenreName) VALUES (1,'Comedy')");
            Sql("INSERT INTO Genres ( Id,GenreName) VALUES (2,'Action')");
            Sql("INSERT INTO Genres ( Id,GenreName) VALUES (3,'Drama')");
            Sql("INSERT INTO Genres ( Id,GenreName) VALUES (4,'Family')");
            Sql("INSERT INTO Genres ( Id,GenreName) VALUES (5,'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
