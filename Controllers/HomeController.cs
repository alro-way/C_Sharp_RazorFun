using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace C_Sharp_Controller.Controllers
{
    public class HomeController : Controller  
    {
        [HttpGet("")]
        public ViewResult HiHome()
        {
            // Views/Home/HiHome.cshtml
            return View();
        }

        [HttpGet("{projects}")]
        public string Projects(string projects)
        {
            return "This is my {projects}!";
        }

        [HttpGet("{contact}")]
        public string Contact(string contact)
        {
            return $"This is my {contact}!";
        }

    }
}