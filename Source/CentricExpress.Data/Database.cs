using System;
using System.Collections.Generic;
using CentricExpress.Data.Entities;

namespace CentricExpress.Data
{
    public static class Database
    {
        public static readonly List<Superhero> Superheroes = new List<Superhero>
        {
            new Superhero
            {
                Id = Guid.NewGuid(),
                Name = "Thor",
                Superpower = "He is a god",
                CombatPower = 20
            },
            new Superhero
            {
                Id = Guid.NewGuid(),
                Name = "Superman",
                Superpower = "He can fly",
                CombatPower = 30
            },
            new Superhero
            {
                Id = Guid.NewGuid(),
                Name = "Captain Marvel",
                Superpower = "Telekinesis",
                CombatPower = 112
            }
        };
    }
}
