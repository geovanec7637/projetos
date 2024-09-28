using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastrocli.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClientRepositorio _clientRepositorio;
        public ClienteController(IClientRepositorio clientRepositorio)
        {
            _clientRepositorio = clientRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
       public IActionResult Criar(cadastrocliModels cadastrocli)
        {
            _clientRepositorio.adicionar(cadastrocli);
            return RedirectToAction("Index");
        }


    }
}
