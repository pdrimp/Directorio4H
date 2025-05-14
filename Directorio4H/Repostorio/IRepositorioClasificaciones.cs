using Directorio4H.Data;

namespace Directorio4H.Repostorio
{
    public interface IRepositorioClasificaciones
    {
        Task<List<Clasificacion>> GetAll();
        Task<Clasificacion> Get(int id);
        Task Add(Clasificacion clasificacion);
        Task Update(Clasificacion clasificacion);
        Task Delete(int id);
    }
}
