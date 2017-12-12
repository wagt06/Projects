namespace Sofia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregatbProductotbProveedores : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clientes", newName: "Cliente");
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 60),
                        Descripcion = c.String(maxLength: 100),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stock = c.Int(nullable: false),
                        IdProveedor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proveedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreP = c.String(),
                        Ruc = c.String(),
                        Telefono = c.String(),
                        Email = c.String(),
                        Direccion = c.String(),
                        IdProducto = c.Int(nullable: false),
                        Producto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Producto", t => t.IdProducto, cascadeDelete: true)
                .ForeignKey("dbo.Producto", t => t.Producto_Id)
                .Index(t => t.IdProducto)
                .Index(t => t.Producto_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Proveedor", "Producto_Id", "dbo.Producto");
            DropForeignKey("dbo.Proveedor", "IdProducto", "dbo.Producto");
            DropIndex("dbo.Proveedor", new[] { "Producto_Id" });
            DropIndex("dbo.Proveedor", new[] { "IdProducto" });
            DropTable("dbo.Proveedor");
            DropTable("dbo.Producto");
            RenameTable(name: "dbo.Cliente", newName: "Clientes");
        }
    }
}
