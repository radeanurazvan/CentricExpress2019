using System;
using System.Collections.Generic;
using CentricExpress.Api.Models;
using CentricExpress.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CentricExpress.Api.Controllers
{
    [Route("v1/superheroes")]
    public class SuperheroesController : Controller
    {
        private readonly ISuperHeroBusinessLogic _businessLogic;

        public SuperheroesController(ISuperHeroBusinessLogic superHeroBusinessLogic)
        {
            _businessLogic = superHeroBusinessLogic;
        }

        [HttpGet("")]
        [ProducesResponseType(typeof(List<SuperheroModel>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var superheroes = _businessLogic.Get();
            return Ok(superheroes);
        }

        [HttpPost("create")]
        [ProducesResponseType(typeof(SuperheroModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody] SuperheroModel model)
        {
            if (model == null)
            {
                return BadRequest();
            }

           _businessLogic.Create(model);
            return Ok();
        }

        [HttpPatch("{id:guid}/{power:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult LevelUp(Guid id, int power)
        {
            var canLevelUp = _businessLogic.LevelUp(id, power);
            return canLevelUp ? (IActionResult) Ok() : BadRequest();
        }
    }
}