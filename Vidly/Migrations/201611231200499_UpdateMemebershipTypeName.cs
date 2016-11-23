namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMemebershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set Name='Pay As You Go',Id=1");
            Sql("Update MembershipTypes set Name='Monthly', Id=2");
            Sql("Update MembershipTypes set Name='Quarterly', Id=3");
            Sql("Update MembershipTypes set Name='Annual', Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
