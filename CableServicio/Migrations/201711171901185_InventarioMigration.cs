namespace CableServicio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InventarioMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Materiales",
                c => new
                    {
                        MaterialId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.MaterialId);
            
            CreateTable(
                "dbo.InventarioMateriales",
                c => new
                    {
                        InventarioMaterialId = c.Int(nullable: false),
                        Existencia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InventarioMaterialId)
                .ForeignKey("dbo.Materiales", t => t.InventarioMaterialId)
                .Index(t => t.InventarioMaterialId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InventarioMateriales", "InventarioMaterialId", "dbo.Materiales");
            DropIndex("dbo.InventarioMateriales", new[] { "InventarioMaterialId" });
            DropTable("dbo.InventarioMateriales");
            DropTable("dbo.Materiales");
        }
    }
}
