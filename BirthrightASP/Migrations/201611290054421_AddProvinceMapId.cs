namespace BirthrightASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProvinceMapId : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProvinceMapIds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MapIdNumber = c.Int(nullable: false),
                        ProvinceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provinces", t => t.ProvinceId)
                .Index(t => t.ProvinceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProvinceMapIds", "ProvinceId", "dbo.Provinces");
            DropIndex("dbo.ProvinceMapIds", new[] { "ProvinceId" });
            DropTable("dbo.ProvinceMapIds");
        }
    }
}
