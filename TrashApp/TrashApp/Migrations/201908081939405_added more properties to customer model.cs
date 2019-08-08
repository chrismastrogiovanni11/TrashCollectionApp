namespace TrashApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmorepropertiestocustomermodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "StartDate", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "EndDate", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "SpecialPickUpDay", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Bill", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "Bill");
        }

        public override void Down()
        {
            AddColumn("dbo.Employees", "Bill", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "Bill");
            DropColumn("dbo.Customers", "SpecialPickUpDay");
            DropColumn("dbo.Customers", "EndDate");
            DropColumn("dbo.Customers", "StartDate");
        }
    }
}
