using System.Collections.Generic;

namespace CentricExpress.Data.Entities
{
    public interface IDatabase
    {
        ICollection<Superhero> SuperheroesList { get; }
    }
}
