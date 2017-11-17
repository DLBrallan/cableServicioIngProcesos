namespace CableServicio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppUsersMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "AppUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Tecnicos", "AppUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Clientes", "AppUser_Id");
            CreateIndex("dbo.Tecnicos", "AppUser_Id");
            AddForeignKey("dbo.Clientes", "AppUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Tecnicos", "AppUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tecnicos", "AppUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Clientes", "AppUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tecnicos", new[] { "AppUser_Id" });
            DropIndex("dbo.Clientes", new[] { "AppUser_Id" });
            DropColumn("dbo.Tecnicos", "AppUser_Id");
            DropColumn("dbo.Clientes", "AppUser_Id");
        }
    }
}
