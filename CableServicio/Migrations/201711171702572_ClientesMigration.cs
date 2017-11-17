namespace CableServicio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientesMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Ciudad = c.String(),
                        Colonia = c.String(),
                        Calle = c.String(),
                        CoidgoPostal = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
