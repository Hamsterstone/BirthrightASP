namespace BirthrightASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTradeRoutes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TradeRoutes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SourceProvinceId = c.Int(nullable: false),
                        DestinationProvinceId = c.Int(nullable: false),
                        OwnerRealmId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provinces", t => t.DestinationProvinceId)
                .ForeignKey("dbo.Realms", t => t.OwnerRealmId)
                .ForeignKey("dbo.Provinces", t => t.SourceProvinceId)
                .Index(t => t.SourceProvinceId)
                .Index(t => t.DestinationProvinceId)
                .Index(t => t.OwnerRealmId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TradeRoutes", "SourceProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.TradeRoutes", "OwnerRealmId", "dbo.Realms");
            DropForeignKey("dbo.TradeRoutes", "DestinationProvinceId", "dbo.Provinces");
            DropIndex("dbo.TradeRoutes", new[] { "OwnerRealmId" });
            DropIndex("dbo.TradeRoutes", new[] { "DestinationProvinceId" });
            DropIndex("dbo.TradeRoutes", new[] { "SourceProvinceId" });
            DropTable("dbo.TradeRoutes");
        }
    }
}
