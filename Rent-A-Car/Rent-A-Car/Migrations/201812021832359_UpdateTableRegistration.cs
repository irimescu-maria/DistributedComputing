namespace Rent_A_Car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTableRegistration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registrations", "IsAuthenticated", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Registrations", "IsAuthenticated");
        }
    }
}
