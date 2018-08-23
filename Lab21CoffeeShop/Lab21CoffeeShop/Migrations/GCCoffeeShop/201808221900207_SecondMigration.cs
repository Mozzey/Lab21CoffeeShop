namespace Lab21CoffeeShop.Migrations.GCCoffeeShop
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 15),
                        LastName = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(nullable: false),
                        Coffee = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            DropTable("dbo.UserModels");
        }
        
        public override void Down()
        {
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
            
            DropTable("dbo.Users");
        }
    }
}
