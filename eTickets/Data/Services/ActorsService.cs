using System.Collections.Generic;
using System.Linq;
using eTickets.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService:IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result =await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetById(int id)
        {
            return await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public async Task<Actor> Update(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return  newActor;
        }

        public async Task Delete(int id)
        {
            var actor =await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            _context.Actors.Remove(actor);
            await _context.SaveChangesAsync();
        }
    }
}