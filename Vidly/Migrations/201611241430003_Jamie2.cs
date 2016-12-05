namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Jamie2 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.TestEFs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TestEFs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DetailsTest = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
    }
}
