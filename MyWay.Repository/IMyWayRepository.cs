using System.Collections.Generic;
using System.Threading.Tasks;
using MyWay.Domain;

namespace MyWay.Repository
{
    public interface IMyWayRepository
    {
        //GERAL
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         Task<bool> SaveChangesAsync();

         //EVENTOS
         Task<Evento[]> GetAllEventosAsyncByTema(string tema);
         Task<Evento[]> GetAllEventosAsync();
         Task<Evento> GetEventosAsyncById(int eventoId);

         //PALESTRANTE
         Task<Palestrante[]> GetAllPalestrantesAsyncByName(string name);
         Task<Palestrante> GetPalestranteAsync(int palestranteId);
    }   
}