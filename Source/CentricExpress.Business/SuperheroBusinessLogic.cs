using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentricExpress.Api.Models;
using CentricExpress.Data;
using CentricExpress.Data.Entities;

namespace CentricExpress.Business
{
    public class SuperheroBusinessLogic : ISuperHeroBusinessLogic
    {
        private readonly IDatabase database;

        public SuperheroBusinessLogic(IDatabase database)
        {
            this.database = database;
        }

        public List<SuperheroModel> Get()
        {

            return database.List.Select(s => new SuperheroModel
            {
                Id = s.Id,
                Name = s.Name,
                CombatPower = s.CombatPower,
                Superpower = s.Superpower
            }).ToList();
        }

        public void Create(SuperheroModel model)
        {
            var entity = new Superhero(model.Name, model.Superpower, model.CombatPower);

            database.Add(entity);
        }

        public bool LevelUp(Guid id, int power)
        {
            if (power > 100)
            {
                throw new BusinessException("Power should be less than 100");
            }

            var hero = database.Find(id);
            hero.LevelUp(power);

            database.Save();

            return true;
        }
    }
}
