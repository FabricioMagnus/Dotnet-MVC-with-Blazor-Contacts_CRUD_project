using Microsoft.AspNetCore.Mvc;
using Projeto_DotNet_MVC.Models;
using System.Diagnostics;

namespace Projeto_DotNet_MVC.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            HomeModel home  = new HomeModel();

            home.Nome = "Fabricio Magnus";
            home.Email = "4aKp1@example.com";

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
