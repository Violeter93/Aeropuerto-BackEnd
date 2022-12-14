using Microsoft.EntityFrameworkCore;

namespace BackEnd.Model
{
    public class MiContexto : DbContext
    {
        public MiContexto(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Aeropuerto> Aeropuertos { get; set; }
    }
}
