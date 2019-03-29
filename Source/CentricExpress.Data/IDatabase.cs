using System.Linq;

namespace CentricExpress.Data.Entities
{
    public interface IDatabase
    {
        IQueryable<Superhero> SuperheroesList { get; }

        void Add(Superhero superhero);

        void CommitChanges();
    }
}
