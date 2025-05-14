using Directorio4H.Data;
using Microsoft.EntityFrameworkCore;

namespace Directorio4H.Repostorio
{
    public class RepositorioClasificaciones : IRepositorioClasificaciones
    {
        private readonly BasedeDatosDbContext _context;

        public RepositorioClasificaciones(BasedeDatosDbContext context)
        {
            _context = context;
        }

        public async Task Add(Clasificacion clasificacion)
        {
            await _context.Clasificaciones.AddAsync(clasificacion);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM Clasificaciones WHERE Id = {0}", id);
        }

        public async Task<Clasificacion> Get(int id)
        {
            return await _context.Clasificaciones.FindAsync(id);
        }

        public async Task<List<Clasificacion>> GetAll()
        {
            return await _context.Clasificaciones.AsNoTracking().ToListAsync();
        }

        public async Task Update(Clasificacion clasificacion)
        {
            _context.Entry(clasificacion).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
