using System;
using System.Collections.Generic;
using System.Text;
using CentricExpress.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CentricExpress.Data.EntityFramework
{
    public class SuperheroesContext : DbContext
    {
        public SuperheroesContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Superhero> Superheroes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SuperheroConfiguration());
        }
    }
}
