namespace Rent_A_Car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteRowFromTableRegistration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Registrations", "IsAuthenticated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Registrations", "IsAuthenticated", c => c.Boolean(nullable: false));
        }
    }
}
