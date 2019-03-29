using System;

namespace CentricExpress.Data.Entities
{
    public class Superhero
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Superpower { get; private set; }

        public int CombatPower { get; private set; }

        public Superhero(string name, string superpower, int combatPower)
        {
            Id = Guid.NewGuid();

            Name = name;
            Superpower = superpower;
            CombatPower = combatPower;
        }
    }
}