using System.Linq;
using CentricExpress.Data.Entities;

namespace CentricExpress.Data
{
    public sealed class InMemorySuperheroRepository : ISuperheroRepository
    {
        private readonly IDatabase _database;

        public InMemorySuperheroRepository(IDatabase database)
        {
            _database = database;
        }

        public IQueryable<Superhero> GetAll()
        {
            return _database.SuperheroesList;
        }

        public void Add(Superhero hero)
        {
            _database.Add(hero);
        }

        public void CommitChanges()
        {
        }
    }
}