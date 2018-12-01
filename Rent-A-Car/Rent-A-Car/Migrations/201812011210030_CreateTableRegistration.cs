namespace Rent_A_Car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableRegistration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        PasswordConfirmation = c.String(nullable: false),
                        RoleId = c.Byte(nullable: false),
                        RoleType_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoleTypes", t => t.RoleType_Id)
                .Index(t => t.RoleType_Id);
            
            CreateTable(
                "dbo.RoleTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registrations", "RoleType_Id", "dbo.RoleTypes");
            DropIndex("dbo.Registrations", new[] { "RoleType_Id" });
            DropTable("dbo.RoleTypes");
            DropTable("dbo.Registrations");
        }
    }
}
