using System;
using System.Collections.Generic;
using System.Text;

namespace CentricExpress.Data.Entities
{
    public class Superhero
    {
        private Superhero()
        {
        }

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Superpower { get; private set; }

        public int CombatPower { get; private set; }

        public Superhero(string name, string superPower, int combatPower)
            : this()
        {
            Id = Guid.NewGuid();

            Name = name;
            Superpower = superPower;
            CombatPower = combatPower;
        }

        public void LevelUp(int power)
        {
            this.CombatPower += power;
        }
    }
}
