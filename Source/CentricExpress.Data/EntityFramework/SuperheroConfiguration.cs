using System;
using System.Collections.Generic;
using System.Text;
using CentricExpress.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentricExpress.Data.EntityFramework
{
    public class SuperheroConfiguration : IEntityTypeConfiguration<Superhero>
    {
        public void Configure(EntityTypeBuilder<Superhero> builder)
        {
            builder.HasKey(hero => hero.Id);
        }
    }
}
