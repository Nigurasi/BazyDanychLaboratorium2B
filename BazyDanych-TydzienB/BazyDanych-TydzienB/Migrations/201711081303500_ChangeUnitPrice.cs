namespace BazyDanych_TydzienB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUnitPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "UnitPrice", c => c.Decimal(nullable: false, storeType: "money"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "UnitPrice");
        }
    }
}
