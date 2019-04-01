using System;
using System.Collections.Generic;
using System.Text;
using CentricExpress.Data.Entities;

namespace CentricExpress.Data
{
    public interface IDatabase
    {
        List<Superhero> List { get; }

        void Add(Superhero hero);

        Superhero Find(Guid id);

        void Save();
    }
}
