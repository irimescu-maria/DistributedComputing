namespace RentalCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyTableRent : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rents", "RentedDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Rents", "ReturnedDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rents", "ReturnedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rents", "RentedDate", c => c.DateTime(nullable: false));
        }
    }
}
