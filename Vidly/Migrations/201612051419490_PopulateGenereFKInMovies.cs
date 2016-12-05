namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenereFKInMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies Set Genre_Id=1 WHERE Id=1");
            Sql("Update Movies set Genre_Id=2 WHERE Id=2");
            Sql("Update Movies set Genre_Id=3 WHERE Id=3");
            Sql("Update Movies set Genre_Id=4 WHERE Id=4");
            Sql("Update Movies set Genre_Id=5 WHERE Id=5");
        }
        
        public override void Down()
        {
        }
    }
}
