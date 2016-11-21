namespace BirthrightASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBorders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Borders",
                c => new
                    {
                        Province1Id = c.Int(nullable: false),
                        Province2Id = c.Int(nullable: false),
                        RiverBorder = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.Province1Id, t.Province2Id })
                .ForeignKey("dbo.Provinces", t => t.Province1Id)
                .ForeignKey("dbo.Provinces", t => t.Province2Id)
                .Index(t => t.Province1Id)
                .Index(t => t.Province2Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Borders", "Province2Id", "dbo.Provinces");
            DropForeignKey("dbo.Borders", "Province1Id", "dbo.Provinces");
            DropIndex("dbo.Borders", new[] { "Province2Id" });
            DropIndex("dbo.Borders", new[] { "Province1Id" });
            DropTable("dbo.Borders");
        }
    }
}
