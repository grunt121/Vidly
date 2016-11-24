namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMovieInfoTable2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieInformations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ReleasedDate = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        NumberInStock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MovieInformations");
        }
    }
}
