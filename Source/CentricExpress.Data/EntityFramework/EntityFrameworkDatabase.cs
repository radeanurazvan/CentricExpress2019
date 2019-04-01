using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentricExpress.Data.Entities;
using CentricExpress.Data.EntityFramework;

namespace CentricExpress.Data
{
    public class EntityFrameworkDatabase : IDatabase
    {
        private SuperheroesContext context;

        public EntityFrameworkDatabase(SuperheroesContext context)
        {
            this.context = context;
        }


        public List<Superhero> List => context.Superheroes.ToList();
        public void Add(Superhero hero)
        {
            context.Superheroes.Add(hero);
            context.SaveChanges();
        }

        public Superhero Find(Guid id)
        {
            return context.Superheroes.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
