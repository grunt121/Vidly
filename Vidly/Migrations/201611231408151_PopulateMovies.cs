namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies ( Name, Genre) VALUES ('Hangover','Comedy')");
            Sql("INSERT INTO Movies ( Name, Genre) VALUES ('Die Hard','Action')");
            Sql("INSERT INTO Movies ( Name, Genre) VALUES ('The Terminator','Action')");
            Sql("INSERT INTO Movies ( Name, Genre) VALUES ('Toy Story','Family')");
            Sql("INSERT INTO Movies ( Name, Genre) VALUES ('Titanic','Romance')");

        }
        public override void Down()
        {
        }
    }
}
