using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {

            List<Departamento> listaDepartamentos = new List<Departamento>();
            listaDepartamentos.Add(new Departamento { ID = 1, Nome = "Eletronicos" });
            listaDepartamentos.Add(new Departamento { ID = 2, Nome = "Movéis" });
            listaDepartamentos.Add(new Departamento {ID = 3, Nome = "Eletrodomésticos" }); 


            return View(listaDepartamentos);
        }
    }
}