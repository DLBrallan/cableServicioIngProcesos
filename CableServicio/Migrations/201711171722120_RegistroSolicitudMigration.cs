namespace CableServicio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegistroSolicitudMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegistroDeSolicitudes",
                c => new
                    {
                        RegistroSolicitudId = c.Int(nullable: false, identity: true),
                        TipoServicioId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RegistroSolicitudId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.TipoServicios", t => t.TipoServicioId, cascadeDelete: true)
                .Index(t => t.TipoServicioId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.TipoServicios",
                c => new
                    {
                        TipoServicioId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.TipoServicioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegistroDeSolicitudes", "TipoServicioId", "dbo.TipoServicios");
            DropForeignKey("dbo.RegistroDeSolicitudes", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.RegistroDeSolicitudes", new[] { "ClienteId" });
            DropIndex("dbo.RegistroDeSolicitudes", new[] { "TipoServicioId" });
            DropTable("dbo.TipoServicios");
            DropTable("dbo.RegistroDeSolicitudes");
        }
    }
}
