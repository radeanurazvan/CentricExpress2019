using System.Collections.Generic;
using System.Linq;
using CentricExpress.Data.Entities;

namespace CentricExpress.Data.EntityFramework
{
    public sealed class EntityFrameworkDatabase : IDatabase
    {
        private readonly SuperheroesContext context;

        public EntityFrameworkDatabase(SuperheroesContext context)
        {
            this.context = context;
        }

        public IQueryable<Superhero> SuperheroesList => this.context.Superheros;

        public void Add(Superhero superhero)
        {
            this.context.Add(superhero);
        }

        public void CommitChanges()
        {
            context.SaveChanges();
        }
    }
}