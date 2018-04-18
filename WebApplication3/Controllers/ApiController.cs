using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Produces("application/json")]
    //[Route("api/Api")]
    public class ApiController : Controller
    {
        private IEnumerable<string> lista = new List<string>() { "giraffe", "badger", "snake" };

        public IActionResult MysteryAnimal(int? id)
        {
            if (id.HasValue && (id.Value < 0 || id.Value >= lista.Count()))
                return BadRequest(new { Message = "Bad animal index" });
            return Ok(new { Value = lista.First() });
        }

        [HttpGet]
        public IEnumerable<string> GetAnimals()
        {
            return lista;
        }

        public object Giraffe()
        {
            return new { name = "giraffe", colour = "yellow", legs = 4 };
        }
    }
}