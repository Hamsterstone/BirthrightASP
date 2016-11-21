namespace BirthrightASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHoldingsAndHoldingTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Holdings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProvinceId = c.Int(nullable: false),
                        Size = c.Int(nullable: false),
                        OwnerId = c.Int(nullable: false),
                        Type_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Realms", t => t.OwnerId)
                .ForeignKey("dbo.Provinces", t => t.ProvinceId)
                .ForeignKey("dbo.HoldingTypes", t => t.Type_Id)
                .Index(t => t.ProvinceId)
                .Index(t => t.OwnerId)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.HoldingTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Holdings", "Type_Id", "dbo.HoldingTypes");
            DropForeignKey("dbo.Holdings", "ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.Holdings", "OwnerId", "dbo.Realms");
            DropIndex("dbo.Holdings", new[] { "Type_Id" });
            DropIndex("dbo.Holdings", new[] { "OwnerId" });
            DropIndex("dbo.Holdings", new[] { "ProvinceId" });
            DropTable("dbo.HoldingTypes");
            DropTable("dbo.Holdings");
        }
    }
}
