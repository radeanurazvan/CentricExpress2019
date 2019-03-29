using System.Linq;
using CentricExpress.Data.Entities;

namespace CentricExpress.Data
{
    public interface ISuperheroRepository
    {
        IQueryable<Superhero> GetAll();

        void Add(Superhero hero);

        void CommitChanges();
    }
}