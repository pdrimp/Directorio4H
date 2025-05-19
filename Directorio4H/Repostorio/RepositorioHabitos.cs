using Directorio4H.Data;
using Microsoft.EntityFrameworkCore;

namespace Directorio4H.Repostorio
{
    public class RepositorioHabitos : IRepositorioHabitos
    {
        private readonly BasedeDatosDbContext _context;

        public RepositorioHabitos(BasedeDatosDbContext context)
        {
            _context = context;
        }

        public async Task Add(Habito habito)
        {
            await _context.Habitos.AddAsync(habito);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM Habitos WHERE Id = {0}", id);
        }

        public async Task<Habito> Get(int id)
        {
            return await _context.Habitos.FindAsync(id);
        }

        public async Task<List<Habito>> GetAll()
        {
            return await _context.Habitos.AsNoTracking().ToListAsync();
        }

        public async Task Update(Habito habito)
        {
            _context.Entry(habito).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
