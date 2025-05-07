using Directorio4H.Data;

namespace Directorio4H.Repostorio
{
    public interface IRepositorioPersonas
    {
        Task<List<Persona>> GetAll();
        Task<Persona> Get(int id);
        Task Add(Persona persona);
        Task Update(Persona persona);
        Task Delete(int id);
    }
}
