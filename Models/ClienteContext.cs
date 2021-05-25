using Microsoft.EntityFrameworkCore;

namespace PC03.Models
{
    public class ClienteContext :DbContext
    {
        public DbSet<Producto> Productos{ get; set; }

        public DbSet<Cliente> Clientes{ get; set; }
    
        public ClienteContext (DbContextOptions dco) : base(dco) {

        }
    }
}