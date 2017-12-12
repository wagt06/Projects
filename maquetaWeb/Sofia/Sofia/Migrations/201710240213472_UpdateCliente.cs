namespace Sofia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCliente : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clientes", "FechaAlta");
            DropColumn("dbo.Clientes", "FechaBaja");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "FechaBaja", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clientes", "FechaAlta", c => c.DateTime(nullable: false));
        }
    }
}
