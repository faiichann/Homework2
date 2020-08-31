using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Homework2.Models;

namespace Homework2.Controllers
{
    public class Order : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult list()
        {

            var game = ("Far Cry 5", "Gta 5", "Dota 2", "Valorant", "Monter Hunter World", "Assassin's Creed",
                "Tom Clancys", "Doom", "Division", "Bettlefield", "Just Cause", "Fall Guys", "Watch Dogs2",
                "Over Wacth", "Devil Maycry5");
            ViewData["game1"] = game.Item1;
            ViewData["game2"] = game.Item2;
            ViewData["game3"] = game.Item3;
            ViewData["game4"] = game.Item4;
            ViewData["game5"] = game.Item5;
            ViewData["game6"] = game.Item6;
            ViewData["game7"] = game.Item7;
            ViewData["game8"] = game.Item8;
            ViewData["game9"] = game.Item9;
            ViewData["game10"] = game.Item10;
            ViewData["game11"] = game.Item11;
            ViewData["game12"] = game.Item12;
            ViewData["game13"] = game.Item13;
            ViewData["game14"] = game.Item14;
            ViewData["game15"] = game.Item15;

            var price = ("620", "550", "360", "130", "480", "510", "610", "220", "145", "310", "210", "510", "650", "430", "220");
            ViewData["price1"] = price.Item1;
            ViewData["price2"] = price.Item2;
            ViewData["price3"] = price.Item3;
            ViewData["price4"] = price.Item4;
            ViewData["price5"] = price.Item5;
            ViewData["price6"] = price.Item6;
            ViewData["price7"] = price.Item7;
            ViewData["price8"] = price.Item8;
            ViewData["price9"] = price.Item9;
            ViewData["price10"] = price.Item10;
            ViewData["price11"] = price.Item11;
            ViewData["price12"] = price.Item12;
            ViewData["price13"] = price.Item13;
            ViewData["price14"] = price.Item14;
            ViewData["price15"] = price.Item15;
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult order()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Buy()
        {
            var game = HttpContext.Request.Form["game"].ToString();
            int Q = Convert.ToInt32(HttpContext.Request.Form["qty"].ToString());
            int P = Convert.ToInt32(HttpContext.Request.Form["pri"].ToString());
            int sum = Q * P;
            ViewBag.qty = Q.ToString();
            ViewBag.pri = P.ToString();
            ViewBag.namegame = game;
            ViewBag.total = sum.ToString();
            return View("order");
        }
        public IActionResult Getname()
        {
            var fullname = HttpContext.Request.Form["name"].ToString();
            ViewBag.name = fullname;
            return View("Login", "Index");
        }
    }
}
