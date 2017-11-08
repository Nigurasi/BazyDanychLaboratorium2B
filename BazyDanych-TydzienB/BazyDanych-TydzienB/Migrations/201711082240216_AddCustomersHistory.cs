namespace BazyDanych_TydzienB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomersHistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomersHistories",
                c => new
                    {
                        HistoryID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.HistoryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomersHistories");
        }
    }
}
