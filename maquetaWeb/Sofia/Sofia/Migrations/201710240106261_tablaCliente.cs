namespace Sofia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablaCliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cedula = c.String(maxLength: 100),
                        Nombres = c.String(maxLength: 100),
                        Apellidos = c.String(maxLength: 100),
                        Direccion = c.String(maxLength: 200),
                        CorreoElectronico = c.String(),
                        Ciudad = c.String(),
                        Departamento = c.String(),
                        LimiteCredito = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaAlta = c.DateTime(nullable: false),
                        FechaBaja = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
