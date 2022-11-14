using System.Collections.Generic;
using System.Threading.Tasks;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Task<Actor> GetById(int id);
        void Add(Actor actor);
        Task<Actor> Update(int id, Actor newActor);
        Task Delete(int id);
    }
}