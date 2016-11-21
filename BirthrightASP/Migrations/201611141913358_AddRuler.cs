namespace BirthrightASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRuler : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rulers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        NameAbbreviation = c.String(nullable: false, maxLength: 10),
                        Player_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Player_Id, cascadeDelete: true)
                .Index(t => t.Player_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rulers", "Player_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Rulers", new[] { "Player_Id" });
            DropTable("dbo.Rulers");
        }
    }
}
