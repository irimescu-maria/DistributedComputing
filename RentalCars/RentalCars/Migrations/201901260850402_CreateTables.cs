namespace RentalCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "CarModel_Id", "dbo.CarModels");
            DropForeignKey("dbo.Cars", "ClassCar_Id", "dbo.CarClasses");
            DropForeignKey("dbo.Cars", "TypeofCar_Id", "dbo.TypeofCars");
            DropForeignKey("dbo.Rentals", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Rentals", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Cars", new[] { "CarModel_Id" });
            DropIndex("dbo.Cars", new[] { "ClassCar_Id" });
            DropIndex("dbo.Cars", new[] { "TypeofCar_Id" });
            DropIndex("dbo.Rentals", new[] { "CustomerId" });
            DropIndex("dbo.Rentals", new[] { "CarId" });
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Class = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transmissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Cars", "FabricationYear", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "Motorization", c => c.String(nullable: false));
            AddColumn("dbo.Cars", "Option", c => c.String(nullable: false));
            AddColumn("dbo.Cars", "Photo", c => c.String(nullable: false));
            AddColumn("dbo.Cars", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "TransmissionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "CategoryId");
            CreateIndex("dbo.Cars", "TransmissionId");
            AddForeignKey("dbo.Cars", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Cars", "TransmissionId", "dbo.Transmissions", "Id", cascadeDelete: true);
            DropColumn("dbo.Cars", "NumberOfKilometers");
            DropColumn("dbo.Cars", "PricePerDay");
            DropColumn("dbo.Cars", "YearOfFabrication");
            DropColumn("dbo.Cars", "StateCar");
            DropColumn("dbo.Cars", "ClassId");
            DropColumn("dbo.Cars", "TypeId");
            DropColumn("dbo.Cars", "ModelId");
            DropColumn("dbo.Cars", "CarModel_Id");
            DropColumn("dbo.Cars", "ClassCar_Id");
            DropColumn("dbo.Cars", "TypeofCar_Id");
            DropTable("dbo.CarClasses");
            DropTable("dbo.CarModels");
            DropTable("dbo.TypeofCars");
            DropTable("dbo.Customers");
            DropTable("dbo.Rentals");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        CarId = c.Int(nullable: false),
                        DateRented = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeofCars",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarClasses",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "TypeofCar_Id", c => c.Byte());
            AddColumn("dbo.Cars", "ClassCar_Id", c => c.Byte());
            AddColumn("dbo.Cars", "CarModel_Id", c => c.Int());
            AddColumn("dbo.Cars", "ModelId", c => c.Byte(nullable: false));
            AddColumn("dbo.Cars", "TypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Cars", "ClassId", c => c.Byte(nullable: false));
            AddColumn("dbo.Cars", "StateCar", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "YearOfFabrication", c => c.DateTime(nullable: false));
            AddColumn("dbo.Cars", "PricePerDay", c => c.Double(nullable: false));
            AddColumn("dbo.Cars", "NumberOfKilometers", c => c.Int(nullable: false));
            DropForeignKey("dbo.Cars", "TransmissionId", "dbo.Transmissions");
            DropForeignKey("dbo.Cars", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Cars", new[] { "TransmissionId" });
            DropIndex("dbo.Cars", new[] { "CategoryId" });
            DropColumn("dbo.Cars", "TransmissionId");
            DropColumn("dbo.Cars", "CategoryId");
            DropColumn("dbo.Cars", "Photo");
            DropColumn("dbo.Cars", "Option");
            DropColumn("dbo.Cars", "Motorization");
            DropColumn("dbo.Cars", "FabricationYear");
            DropColumn("dbo.Cars", "Name");
            DropTable("dbo.Transmissions");
            DropTable("dbo.Categories");
            CreateIndex("dbo.Rentals", "CarId");
            CreateIndex("dbo.Rentals", "CustomerId");
            CreateIndex("dbo.Cars", "TypeofCar_Id");
            CreateIndex("dbo.Cars", "ClassCar_Id");
            CreateIndex("dbo.Cars", "CarModel_Id");
            AddForeignKey("dbo.Rentals", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rentals", "CarId", "dbo.Cars", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Cars", "TypeofCar_Id", "dbo.TypeofCars", "Id");
            AddForeignKey("dbo.Cars", "ClassCar_Id", "dbo.CarClasses", "Id");
            AddForeignKey("dbo.Cars", "CarModel_Id", "dbo.CarModels", "Id");
        }
    }
}
