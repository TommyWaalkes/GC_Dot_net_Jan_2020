using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FirstMVCApp.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult Html5()
        {
            return View();
        }

        public IActionResult DataAno()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DataAno(User u)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("UserResult", u);
            }
            else
            {
                return View(u);
            }
        }

        public IActionResult UserResult(User u)
        {  
            return View(u);
        }

        public IActionResult ControllerSide()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ControllerSide(Fish f)
        {
            Regex.IsMatch("1234", "");
            if (f.Name == "Carl")
            {
                return RedirectToAction("Error");
            }
            else
            {
                ViewBag.Name = f.Name;
            }

            ViewBag.Scales = f.Scales;

            if (f.IsFreshWater)
            {
                ViewBag.Water = "Ah it's a lake Fish!";
            }
            else
            {
                ViewBag.Water = "So, you have a salty boy Ocean Fish";
            }

            if (f.Species == "Salmon")
            {
                ViewBag.Salmon = "Salmon!!!!";
            }
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
