﻿using Microsoft.AspNetCore.Mvc;

namespace Projeto_DotNet_MVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    public IActionResult CreateContact()
    {
      return View();
    }

    public IActionResult EditContact()
    {
      return View();
    }

    public IActionResult RemoveContact()
    {
      return View();
    }
  }
}
