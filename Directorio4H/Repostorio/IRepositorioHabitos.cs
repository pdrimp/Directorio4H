using Directorio4H.Data;

namespace Directorio4H.Repostorio
{
    public interface IRepositorioHabitos
    {
        Task<List<Habito>> GetAll();
        Task<Habito> Get(int id);
        Task Add(Habito habito);
        Task Update(Habito habito);
        Task Delete(int id);
    }
}
