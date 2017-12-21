namespace ApiRestInventario.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class InventarioModel : DbContext
    {
        public InventarioModel()
            : base("name=InventarioModel")
        {
        }

        public virtual DbSet<Productos> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>()
                .Property(e => e.Precio)
                .HasPrecision(19, 4);
        }
    }
}
