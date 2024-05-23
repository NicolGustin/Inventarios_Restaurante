using Inventarios_Restaurante.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventarios_Restaurante.Data
{
    public class InventarioContext : DbContext
    {

        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Plato> Platos { get; set; }
        public DbSet<DetallePlato> DetallesPlato { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Compra> Compras { get; set; }

        /** protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         optionsBuilder.UseSqlServer(
         "Server=(localdb)\\mssqllocaldb;Database=SupermarketEF;Trusted_Connection=True;");
        }**/

    }
}
