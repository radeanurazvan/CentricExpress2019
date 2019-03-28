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

        public void Add(SuperheroModel model)
        {
            var superhero = new Superhero(
                model.Name, 
                model.Superpower, 
                model.CombatPower);

            database.SuperheroesList.Add(superhero);
        }
    }
}