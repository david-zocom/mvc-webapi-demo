using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ExampleController : Controller
    {
        [Route("x")]
        [Route("Example/Index")]
        public IActionResult Index()
        {
            ExampleViewModel evm = new ExampleViewModel() { Value = "From Index action" };
            return View(evm);
        }

        public IActionResult Action1()
        {
            ExampleViewModel evm = new ExampleViewModel() { Value = "From Action1 action" };
            return View("Index", evm);
        }

        public IActionResult Action2()
        {
            return Redirect("https://www.google.se");
            //return RedirectToAction("About", "Home");
        }

        /*public IActionResult Test()
        {
            return Ok(new { Value = "test", Value2 = 5 });
            //return BadRequest(new { Message = "Error!!" });
        }
        public object Test2()
        {
            return new { Value = "test", Value2 = 5 };
        }
        public IActionResult Test3()
        {
            return BadRequest(new { Message = "Error!!" });
        }*/
    }
}