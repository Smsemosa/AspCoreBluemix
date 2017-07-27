using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Welcome to Shalom Systems";
            return View();
        }
        [HttpGet]
        //the html.action works/html.renderaction
        public PartialViewResult LoadLogin()
        {

            return PartialView();
        }
    }
}
