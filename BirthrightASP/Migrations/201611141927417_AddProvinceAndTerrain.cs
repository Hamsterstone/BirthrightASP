namespace BirthrightASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProvinceAndTerrain : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Size = c.Int(nullable: false),
                        RealmId = c.Int(nullable: false),
                        Loyalty = c.String(),
                        Road = c.Boolean(nullable: false),
                        Terrain_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Realms", t => t.RealmId, cascadeDelete: true)
                .ForeignKey("dbo.Terrains", t => t.Terrain_Id, cascadeDelete: true)
                .Index(t => t.RealmId)
                .Index(t => t.Terrain_Id);
            
            CreateTable(
                "dbo.Terrains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 50),
                        Province_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provinces", t => t.Province_Id)
                .Index(t => t.Province_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Provinces", "Terrain_Id", "dbo.Terrains");
            DropForeignKey("dbo.Terrains", "Province_Id", "dbo.Provinces");
            DropForeignKey("dbo.Provinces", "RealmId", "dbo.Realms");
            DropIndex("dbo.Terrains", new[] { "Province_Id" });
            DropIndex("dbo.Provinces", new[] { "Terrain_Id" });
            DropIndex("dbo.Provinces", new[] { "RealmId" });
            DropTable("dbo.Terrains");
            DropTable("dbo.Provinces");
        }
    }
}
