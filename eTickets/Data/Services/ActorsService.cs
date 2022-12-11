using System.Collections.Generic;
using System.Linq;
using eTickets.Models;
using System.Threading.Tasks;
using eTickets.Data.Base;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService:EntityBaseRepository<Actor>, IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context):base(context)
        {
           
        }
       
    }
}