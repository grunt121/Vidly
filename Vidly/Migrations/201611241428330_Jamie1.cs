namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Jamie1 : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.TestEFs");
        }
    }
}
