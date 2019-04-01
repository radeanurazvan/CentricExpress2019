using System;

namespace CentricExpress.Presentation.Models
{
    public class Superhero
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Superpower Superpower { get; set; }

        public bool IsAlive { get; set; }
    }
}