using System.Collections.Generic;
using CentricExpress.Business;
using CentricExpress.Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CentricExpress.Api.Controllers
{
    [Route("v1/superheroes")]
    public class SuperheroesController : Controller
    {
        private readonly ISuperheroBusiness _business;

        public SuperheroesController(ISuperheroBusiness superheroBusiness)
        {
            _business = superheroBusiness;
        }

        [HttpGet("")]
        [ProducesResponseType(typeof(List<SuperheroModel>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var models = _business.Get();
            return Ok(models);
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

            _business.Add(model);

            return Ok();
        }
    }
}