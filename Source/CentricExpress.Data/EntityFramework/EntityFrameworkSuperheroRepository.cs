using System.Linq;
using CentricExpress.Data.Entities;

namespace CentricExpress.Data.EntityFramework
{
    public sealed class EntityFrameworkSuperheroRepository : ISuperheroRepository
    {
        private readonly SuperheroesContext _context;

        public EntityFrameworkSuperheroRepository(SuperheroesContext context)
        {
            _context = context;
        }

        public IQueryable<Superhero> GetAll()
        {
            return _context.Superheros;
        }

        public void Add(Superhero hero)
        {
            _context.Superheros.Add(hero);
        }

        public void CommitChanges()
        {
            _context.SaveChanges();
        }
    }
}