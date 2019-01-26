namespace RentalCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidationForCarModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Cars", "Motorization", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.Cars", "Option", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Option", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "Motorization", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "Name", c => c.String(nullable: false));
        }
    }
}
