﻿using System;
using System.Collections.Generic;
using System.Text;
using CentricExpress.Data.Entities;

namespace CentricExpress.Data
{
    public class Database : IDatabase
    {
        private static readonly List<Superhero> Superheroes = new List<Superhero>
        {
            new Superhero("Thor", "He is a god", 20),
            new Superhero("Superman", "He can fly", 30),
            new Superhero("Captain Marvel", "Telekinesis", 112)
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
