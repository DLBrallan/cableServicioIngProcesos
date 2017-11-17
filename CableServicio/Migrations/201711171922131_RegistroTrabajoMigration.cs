namespace CableServicio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegistroTrabajoMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegistroTrabajoes",
                c => new
                    {
                        RegistroTrabajoId = c.Int(nullable: false, identity: true),
                        TecnicoId = c.Int(nullable: false),
                        HorasTrabajadas = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Tecnico_TecnicoId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RegistroTrabajoId)
                .ForeignKey("dbo.Tecnicos", t => t.Tecnico_TecnicoId)
                .Index(t => t.Tecnico_TecnicoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegistroTrabajoes", "Tecnico_TecnicoId", "dbo.Tecnicos");
            DropIndex("dbo.RegistroTrabajoes", new[] { "Tecnico_TecnicoId" });
            DropTable("dbo.RegistroTrabajoes");
        }
    }
}
