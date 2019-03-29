using System.Collections.Generic;
using System.Linq;
using CentricExpress.Business.Models;
using CentricExpress.Data.Entities;

namespace CentricExpress.Business
{
    public class SuperheroBusiness : ISuperheroBusiness
    {
        private readonly IDatabase database;

        public SuperheroBusiness(IDatabase database)
        {
            this.database = database;
        }

        public IReadOnlyCollection<SuperheroModel> Get()
        {
            return database.SuperheroesList
                .Select(h => new SuperheroModel
                {
                    Id = h.Id,
                    CombatPower = h.CombatPower,
                    Name = h.Name,
                    Superpower = h.Superpower
                }).ToList().AsReadOnly();
        }
        
        public SuperheroModel FindByName(string name)
        {
            var superhero = this.database.SuperheroesList.FirstOrDefault(h => h.Name == name);
            if (superhero == null)
            {
                return null;
            }

            return new SuperheroModel
            {
                Id = superhero.Id,
                CombatPower = superhero.CombatPower,
                Name = superhero.Name,
                Superpower = superhero.Superpower
            };
        }

        public void Add(SuperheroModel model)
        {
            var superhero = new Superhero(
                model.Name, 
                model.Superpower, 
                model.CombatPower);

            database.Add(superhero);
            database.CommitChanges();
        }
    }
}