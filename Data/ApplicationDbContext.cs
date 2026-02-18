using Microsoft.EntityFrameworkCore;
using GestionInventario.Api.Models;

namespace GestionInventario.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Esta es la tabla que se creará en SQL
        public DbSet<Producto> Productos { get; set; }
    }
}
