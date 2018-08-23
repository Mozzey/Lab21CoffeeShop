namespace Lab21CoffeeShop.Migrations.GCCoffeeShop
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDummyData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Coffee", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Coffee", c => c.String(nullable: false));
        }
    }
}
