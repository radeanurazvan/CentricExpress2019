using CentricExpress.Data.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentricExpress.Data.EntityFramework
{
    public sealed class SuperheroConfiguration : IEntityTypeConfiguration<Superhero>
    {
        public void Configure(EntityTypeBuilder<Superhero> builder)
        {
            builder.HasKey(h => h.Id);
        }
    }
}