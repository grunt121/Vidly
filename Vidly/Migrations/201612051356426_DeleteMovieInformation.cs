namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteMovieInformation : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.MovieInformations");
        }
        
        public override void Down()
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
    }
}
