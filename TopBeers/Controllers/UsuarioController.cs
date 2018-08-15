using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TopBeers.Models;

namespace TopBeers.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult ValidarLogin(UsuarioModel usuario)
        //{
        //    if (login)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    } else
        //    {
        //        return RedirectToActio("Login", "Home");
        //    }
        //}

        public IActionResult ValidarLogin(UsuarioModel usuario)
        {
            var user = usuario;

            return RedirectToAction("Login", "Home");
        }
    }
}