using System;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [Route("painel/admin")]
    public class AdminController : Controller
    {
        [HttpGet("principal/{numero:int?}/{nome}")]
        public IActionResult Index(int numero, string nome){
            return Content("Ola mundo numero" + numero + "nome" + nome);
        }

        [HttpGet("son")]
        public IActionResult schoolOfNet(){
            var nome = Request.Query["nome"];
            return Content("teste 132" + nome);
        }

        [HttpGet("view")]
        public IActionResult visualizar(){
            ViewData["helloWorld"] = false;
            return View();
        }
    }
}