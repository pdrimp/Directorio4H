using Microsoft.EntityFrameworkCore;

namespace Directorio4H.Data
{
    public class BasedeDatosDbContext : DbContext
    {
        public BasedeDatosDbContext(
                 DbContextOptions<BasedeDatosDbContext> options
                                   )
            : base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }
    }
}
