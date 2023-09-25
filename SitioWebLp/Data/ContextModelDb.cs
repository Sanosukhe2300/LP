using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SitioWebLp.Data
{
    public partial class ContextModelDb : DbContext
    {
        public ContextModelDb()
            : base("name=ContextModelDb")
        {
        }

        public virtual DbSet<LP_Producto> LP_Producto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LP_Producto>()
                .Property(e => e.Precio)
                .HasPrecision(10, 2);
        }
    }
}
