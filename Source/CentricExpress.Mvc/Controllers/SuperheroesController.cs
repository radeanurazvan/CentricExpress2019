using System;
using System.Collections.Generic;
using CentricExpress.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace CentricExpress.Presentation.Controllers
{
    public class SuperheroesController : Controller
    {
        public IActionResult Index()
        {
            var godPower = new Superpower
            {
                Id = Guid.NewGuid(),
                Name = "Is a God",
                CombatPower = 100
            };
            
            var flyPower = new Superpower
            {
                Id = Guid.NewGuid(),
                Name = "Can fly with sound speed",
                CombatPower = 50
            };

            var superheroes = new List<Superhero>
            {
                new Superhero
                {
                    Id = Guid.NewGuid(),
                    Name = "Thor",
                    Age = 450,
                    IsAlive = true,
                    Superpower = godPower
                },
                new Superhero
                {
                    Id = Guid.NewGuid(),
                    Name = "Superman",
                    Age = 30,
                    IsAlive = true,
                    Superpower = flyPower
                },
                new Superhero
                {
                    Id = Guid.NewGuid(),
                    Name = "Captain Marvel",
                    Age = 25,
                    IsAlive = true,
                    Superpower = flyPower
                },
            };

            return View(superheroes);
        }
    }
}