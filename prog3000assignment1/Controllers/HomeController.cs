using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using prog3000assignment1.Models;

namespace prog3000assignment1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RequestForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RequestForm(Request request)
        {
            if (ModelState.IsValid)
            {
                Repository.InsertRequest(request);
                return View("Confirmation");
            }
            else
            {
                return View();
            }
        }
        public IActionResult AllEquipment()
        {
            return View();
        }
        public IActionResult AvailableEquipments()
        {
            return View();
        }
    }
}