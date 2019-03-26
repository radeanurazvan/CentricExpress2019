using System;
using System.Collections.Generic;
using System.Linq;
using CentricExpress.Business.Models;
using CentricExpress.Data;
using CentricExpress.Data.Entities;

namespace CentricExpress.Business
{
    public class SuperheroBusiness
    {
        public IReadOnlyCollection<SuperheroModel> Get()
        {
            return Database.Superheroes
                .Select(h => new SuperheroModel
                {
                    Id = h.Id,
                    CombatPower = h.CombatPower,
                    Name = h.Name,
                    Superpower = h.Superpower
                }).ToList()
                .AsReadOnly();
        }

        public void Add(SuperheroModel model)
        {
            var superhero = new Superhero
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                CombatPower = model.CombatPower,
                Superpower = model.Superpower
            };

            Database.Superheroes.Add(superhero);
        }
    }
}