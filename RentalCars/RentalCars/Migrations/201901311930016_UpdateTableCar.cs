namespace RentalCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTableCar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Price");
        }
    }
}
