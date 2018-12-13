namespace Rent_A_Car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCreatedTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Name");
        }
    }
}
