using System;
using System.Collections.Generic;
using System.Text;
using CentricExpress.Data.Entities;

namespace CentricExpress.Data
{
    public class NewDatabase : IDatabase
    {
        private static readonly List<Superhero> Superheroes = new List<Superhero>
        {
            new Superhero("Spiderman", "Spidey sense", 20)
        };

        public List<Superhero> List
        {
            get { return Superheroes; }
        }

        public void Add(Superhero hero)
        {
        }

        public Superhero Find(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
