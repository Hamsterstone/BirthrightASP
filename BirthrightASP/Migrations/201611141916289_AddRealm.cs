namespace BirthrightASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRealm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Realms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        RulerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rulers", t => t.RulerId, cascadeDelete: true)
                .Index(t => t.RulerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Realms", "RulerId", "dbo.Rulers");
            DropIndex("dbo.Realms", new[] { "RulerId" });
            DropTable("dbo.Realms");
        }
    }
}
