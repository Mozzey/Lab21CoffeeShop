namespace Lab21CoffeeShop.Migrations.GCCoffeeShop
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemModels",
                c => new
                    {
                        ItemModelID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ItemModelID);
            
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        UserModelID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 15),
                        LastName = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(nullable: false),
                        Coffee = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserModelID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserModels");
            DropTable("dbo.ItemModels");
        }
    }
}
