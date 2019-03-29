﻿// <auto-generated />
using System;
using CentricExpress.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CentricExpress.Data.Migrations
{
    [DbContext(typeof(SuperheroesContext))]
    partial class SuperheroesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CentricExpress.Data.Entities.Superhero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CombatPower");

                    b.Property<string>("Name");

                    b.Property<string>("Superpower");

                    b.HasKey("Id");

                    b.ToTable("Superheros");
                });
#pragma warning restore 612, 618
        }
    }
}
