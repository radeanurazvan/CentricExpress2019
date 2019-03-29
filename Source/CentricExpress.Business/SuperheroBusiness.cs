using System.Collections.Generic;
using System.Linq;
using CentricExpress.Business.Models;
using CentricExpress.Data;
using CentricExpress.Data.Entities;

namespace CentricExpress.Business
{
    public class SuperheroBusiness : ISuperheroBusiness
    {
        private readonly ISuperheroRepository repository;

        public SuperheroBusiness(ISuperheroRepository repository)
        {
            this.repository = repository;
        }

        public IReadOnlyCollection<SuperheroModel> Get()
        {
            return repository.GetAll()
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
            var superhero = this.repository.GetAll().FirstOrDefault(h => h.Name == name);
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

            repository.Add(superhero);
            repository.CommitChanges();
        }
    }
}