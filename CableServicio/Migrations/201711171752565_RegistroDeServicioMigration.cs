namespace CableServicio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegistroDeServicioMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Tecnicoes", newName: "Tecnicos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Tecnicos", newName: "Tecnicoes");
        }
    }
}
