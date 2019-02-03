namespace RentalCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTableRent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rents", "Username", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rents", "Username");
        }
    }
}
