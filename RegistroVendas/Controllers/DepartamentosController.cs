using Microsoft.AspNetCore.Mvc;
using RegistroVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroVendas.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Vestuário" });
            list.Add(new Departamento { Id = 2, Nome = "Decoração" });
            return View(list);
        }
    }
}
