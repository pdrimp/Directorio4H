using Directorio4H.Data;
using Microsoft.EntityFrameworkCore;

namespace Directorio4H.Repostorio
{
    public class RepositorioPersonas : IRepositorioPersonas
    {
        private readonly BasedeDatosDbContext _context;

        public RepositorioPersonas(BasedeDatosDbContext context)
        {
            _context = context;
        }

        public async Task Add(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM Personas WHERE Id = {0}", id);
        }

        public async Task<Persona> Get(int id)
        {
            return await _context.Personas.FindAsync(id);
        }

        public async Task<List<Persona>> GetAll()
        {
            return await _context.Personas.AsNoTracking().ToListAsync();
        }

        public async Task Update(Persona persona)
        {
            _context.Entry(persona).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
