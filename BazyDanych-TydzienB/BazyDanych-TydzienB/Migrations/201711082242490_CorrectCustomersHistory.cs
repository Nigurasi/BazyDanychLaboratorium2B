namespace BazyDanych_TydzienB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectCustomersHistory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomersHistories", "BoughtProductID", c => c.Int(nullable: false));
            AddColumn("dbo.CustomersHistories", "BoughtDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomersHistories", "BoughtDate");
            DropColumn("dbo.CustomersHistories", "BoughtProductID");
        }
    }
}
