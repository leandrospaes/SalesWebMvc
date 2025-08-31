using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SalesWebMvc.Models;


namespace SalesWebMvc.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Models.Department> list = new List<Models.Department>();
            list.Add(new Models.Department { Id = 1, Name = "Livros" }); 
            list.Add(new Models.Department { Id = 2, Name = "Eletronicos" });


            return View(list);
        }
    }
}
