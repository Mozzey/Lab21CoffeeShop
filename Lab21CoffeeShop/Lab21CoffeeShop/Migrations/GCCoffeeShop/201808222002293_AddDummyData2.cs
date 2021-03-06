namespace Lab21CoffeeShop.Migrations.GCCoffeeShop
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDummyData2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "FirstName", c => c.String());
            AlterColumn("dbo.Users", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "LastName", c => c.String(maxLength: 15));
            AlterColumn("dbo.Users", "FirstName", c => c.String(maxLength: 15));
        }
    }
}
