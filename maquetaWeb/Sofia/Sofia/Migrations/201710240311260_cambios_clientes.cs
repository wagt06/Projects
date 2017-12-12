namespace Sofia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambios_clientes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Cedula", c => c.String(maxLength: 14));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Cedula", c => c.String(maxLength: 11));
        }
    }
}
