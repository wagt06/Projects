namespace Sofia.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SofiaDb : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'SofiaDb' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Sofia.Models.SofiaDb' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'SofiaDb'  en el archivo de configuración de la aplicación.
        public SofiaDb()
            : base("name=SofiaDb")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.
        

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            //relacion 
            //Productos y proveedores
            //  modelBuilder.Entity<Producto>().HasMany(x => x.Proveedor).WithOptional(t=>t.Producto);
            //modelBuilder.Entity<Producto>().HasRequired(x => x.Proveedor).WithMany().HasForeignKey(t => t.IdProveedor);
            modelBuilder.Entity<Proveedor>().HasRequired(x => x.Producto).WithMany().HasForeignKey(t => t.IdProducto);

           // modelBuilder.Entity<Producto>().HasMany(x => x.Proveedor).WithMany(x => x.Producto);

        }
    }

   

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}