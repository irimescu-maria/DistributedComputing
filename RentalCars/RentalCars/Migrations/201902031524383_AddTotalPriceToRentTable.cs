namespace RentalCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTotalPriceToRentTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rents", "TotalPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rents", "TotalPrice");
        }
    }
}
