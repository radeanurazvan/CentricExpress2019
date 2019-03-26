using System;
using System.Collections.Generic;
using CentricExpress.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CentricExpress.Api.Controllers
{
    [Route("v1/superheroes")]
    public class SuperheroesController : Controller
    {
        private static readonly List<Superhero> Superheroes = new List<Superhero>
        {
            new Superhero
            {
                Id = Guid.NewGuid(),
                Name = "Thor",
                Superpower = "He is a god",
                CombatPower = 20
            },
            new Superhero
            {
                Id = Guid.NewGuid(),
                Name = "Superman",
                Superpower = "He can fly",
                CombatPower = 30
            },
            new Superhero
            {
                Id = Guid.NewGuid(),
                Name = "Captain Marvel",
                Superpower = "Telekinesis",
                CombatPower = 112
            }
        };

        [HttpGet("")]
        [ProducesResponseType(typeof(List<Superhero>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(Superheroes);
        }

        [HttpPost("create")]
        [ProducesResponseType(typeof(Superhero), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody] Superhero model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            Superheroes.Add(model);
            return Ok();
        }
    }
}