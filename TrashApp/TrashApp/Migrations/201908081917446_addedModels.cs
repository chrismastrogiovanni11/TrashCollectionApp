namespace TrashApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StreetAddress = c.String(),
                        ZipCode = c.Int(nullable: false),
                        City = c.String(),
                        State = c.String(),
                        PickUpDay = c.Int(nullable: false),
                        ApplicationId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationId)
                .Index(t => t.ApplicationId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ZipCode = c.Int(nullable: false, identity: true),
                        Bill = c.Int(nullable: false),
                        ApplicationId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ZipCode)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationId)
                .Index(t => t.ApplicationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "ApplicationId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Customers", "ApplicationId", "dbo.AspNetUsers");
            DropIndex("dbo.Employees", new[] { "ApplicationId" });
            DropIndex("dbo.Customers", new[] { "ApplicationId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }

}
