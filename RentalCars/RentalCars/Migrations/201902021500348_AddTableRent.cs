namespace RentalCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableRent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 160),
                        LastName = c.String(nullable: false, maxLength: 160),
                        Phone = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        RentedDate = c.DateTime(nullable: false),
                        ReturnedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CarId)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Rents", "CarId", "dbo.Cars");
            DropIndex("dbo.Rents", new[] { "CustomerId" });
            DropIndex("dbo.Rents", new[] { "CarId" });
            DropTable("dbo.Rents");
            DropTable("dbo.Customers");
        }
    }
}
