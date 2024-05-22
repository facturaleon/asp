using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApplication1Test.Models;

namespace WebApplication1Test.Data
{
    public class DatabaseContext : DbContext 
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> option) : base(option)
        { }
    }
}
