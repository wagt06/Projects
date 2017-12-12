namespace Sofia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_cliente1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Cedula", c => c.String(maxLength: 11));
            AlterColumn("dbo.Clientes", "Nombres", c => c.String(maxLength: 80));
            AlterColumn("dbo.Clientes", "Apellidos", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Apellidos", c => c.String(maxLength: 100));
            AlterColumn("dbo.Clientes", "Nombres", c => c.String(maxLength: 100));
            AlterColumn("dbo.Clientes", "Cedula", c => c.String(maxLength: 100));
        }
    }
}
