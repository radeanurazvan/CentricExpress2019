using System;

namespace CentricExpress.Data.Entities
{
    public class Superhero
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Superpower { get; set; }

        public int CombatPower { get; set; }
    }
}