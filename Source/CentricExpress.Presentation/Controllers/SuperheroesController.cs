using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CentricExpress.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace CentricExpress.Presentation.Controllers
{
    public class SuperheroesController : Controller
    {
        private readonly HttpClient _client;
        public SuperheroesController()
        {
            _client = new HttpClient();
        }

        public async Task<IActionResult> Index()
        {
            var superheroes = new List<Superhero>();

            var response = await _client.GetAsync("http://localhost:38567/v1/superheroes");
            if (response.IsSuccessStatusCode)
            {
                superheroes = await response.Content.ReadAsAsync<List<Superhero>>();
            }

            return View(superheroes);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Superhero model)
        {
            var response = await _client.PostAsJsonAsync("http://localhost:38567/v1/superheroes/create", model);
            response.EnsureSuccessStatusCode();

            return RedirectToAction("Index");
        }
    }
}