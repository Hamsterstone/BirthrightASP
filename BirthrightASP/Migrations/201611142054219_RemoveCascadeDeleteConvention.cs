namespace BirthrightASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCascadeDeleteConvention : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Provinces", "RealmId", "dbo.Realms");
            DropForeignKey("dbo.Provinces", "Terrain_Id", "dbo.Terrains");
            DropForeignKey("dbo.Realms", "RulerId", "dbo.Rulers");
            DropForeignKey("dbo.Rulers", "Player_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            AddForeignKey("dbo.Provinces", "RealmId", "dbo.Realms", "Id");
            AddForeignKey("dbo.Provinces", "Terrain_Id", "dbo.Terrains", "Id");
            AddForeignKey("dbo.Realms", "RulerId", "dbo.Rulers", "Id");
            AddForeignKey("dbo.Rulers", "Player_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Rulers", "Player_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Realms", "RulerId", "dbo.Rulers");
            DropForeignKey("dbo.Provinces", "Terrain_Id", "dbo.Terrains");
            DropForeignKey("dbo.Provinces", "RealmId", "dbo.Realms");
            AddForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rulers", "Player_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Realms", "RulerId", "dbo.Rulers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Provinces", "Terrain_Id", "dbo.Terrains", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Provinces", "RealmId", "dbo.Realms", "Id", cascadeDelete: true);
        }
    }
}
