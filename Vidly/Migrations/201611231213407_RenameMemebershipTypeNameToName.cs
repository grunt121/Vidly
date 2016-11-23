namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMemebershipTypeNameToName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            DropColumn("dbo.MembershipTypes", "MembershipTypeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "MembershipTypeName", c => c.String());
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
