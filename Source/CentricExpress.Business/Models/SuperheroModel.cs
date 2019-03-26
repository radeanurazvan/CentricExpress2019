using System;

namespace CentricExpress.Business.Models
{
    public class SuperheroModel
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }

        public string Superpower { get; set; }

        public int CombatPower { get; set; }
    }
}