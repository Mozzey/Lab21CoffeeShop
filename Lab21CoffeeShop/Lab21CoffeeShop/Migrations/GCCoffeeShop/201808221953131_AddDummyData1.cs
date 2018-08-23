namespace Lab21CoffeeShop.Migrations.GCCoffeeShop
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDummyData1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "FirstName", c => c.String(maxLength: 15));
            AlterColumn("dbo.Users", "LastName", c => c.String(maxLength: 15));
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "ConfirmPassword", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "ConfirmPassword", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 15));
        }
    }
}
