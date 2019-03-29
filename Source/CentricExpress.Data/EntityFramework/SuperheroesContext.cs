using CentricExpress.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CentricExpress.Data.EntityFramework
{
    public sealed class SuperheroesContext : DbContext
    {
        public SuperheroesContext(DbContextOptions<SuperheroesContext> options) 
            : base(options)
        {
        }

        public DbSet<Superhero> Superheros { get; set; }
    }
}