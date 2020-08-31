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
            var listgame = new List<ListData>();
            listgame.Add(new ListData { game = "Far Cry 5", price = 620 ,url= "https://www.gamesrig.com/img/index/far-cry-5-cover.jpg" });
            listgame.Add(new ListData { game = "Gta V", price = 550 , url= "https://www.gamesrig.com/img/index/grand-theft-auto-v-cover.jpg" });
            listgame.Add(new ListData { game = "Dota 2", price = 360  ,url = "https://www.gamesrig.com/img/index/watch-dogs-2-cover.jpg" });
            listgame.Add(new ListData { game = "Valorant", price = 130, url = "https://cdn.game.tv/game-tv-content/images_3/07e71c74484a1cedd92dbc35fa0c0304/GameTile.jpg" });
            listgame.Add(new ListData { game = "Monter Hunter World", price = 480, url = "https://www.gamesrig.com/img/index/monster-hunter-world-cover.jpg" });
            listgame.Add(new ListData { game = "Assassin's Creed", price = 510, url = "https://www.gamesrig.com/img/index/tom-clancys-ghost-recon-wildlands-cover.jpg" });
            listgame.Add(new ListData { game = "Tom Clancys", price = 610, url = "https://www.gamesrig.com/img/index/tom-clancys-the-division-cover.jpg" });
            listgame.Add(new ListData { game = "Doom", price = 220, url = "https://www.gamesrig.com/img/index/doom-cover.jpg" });
            listgame.Add(new ListData { game = "Division", price = 145, url = "https://www.gamesrig.com/img/index/battlefield-1-premium-pass-cover.jpg" });
            listgame.Add(new ListData { game = "Bettlefield", price = 310, url = "https://www.gamesrig.com/img/index/just-cause-4-cover.jpg" });
            listgame.Add(new ListData { game = "Just Cause", price = 210, url = "https://media.playstation.com/is/image/SCEA/fall-guys-ultimate-knockout-boxart-01-ps4-23jun20-en-hk?$native_nt$" });
            listgame.Add(new ListData { game = "Fall Guys", price = 510, url = "https://www.gamesrig.com/img/index/overwatch-legendary-edition-cover.jpg" });
            listgame.Add(new ListData { game = "Watch Dogs2", price = 650, url = "https://th-test-11.slatic.net/p/474b0fd02c735df50b5fbec4dd30cbf0.jpg" });
            listgame.Add(new ListData { game = "Over Wacth", price = 430, url = "https://images-na.ssl-images-amazon.com/images/I/71cTCvSFJTL._SY500_.jpg" });
            listgame.Add(new ListData { game = "Devil Maycry5", price = 220, url = "https://upload.wikimedia.org/wikipedia/ru/thumb/8/8e/%D0%9E%D0%B1%D0%BB%D0%BE%D0%B6%D0%BA%D0%B0_Dota_2.jpg/266px-%D0%9E%D0%B1%D0%BB%D0%BE%D0%B6%D0%BA%D0%B0_Dota_2.jpg" });
            return View(listgame.ToList());
        }
        public IActionResult order()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Buy()
        {
            int A = Convert.ToInt32(HttpContext.Request.Form["a"].ToString());
            int B = Convert.ToInt32(HttpContext.Request.Form["b"].ToString());
            int C = Convert.ToInt32(HttpContext.Request.Form["c"].ToString());
            int D = Convert.ToInt32(HttpContext.Request.Form["d"].ToString());
            int E = Convert.ToInt32(HttpContext.Request.Form["e"].ToString());
            int F = Convert.ToInt32(HttpContext.Request.Form["f"].ToString());
            int G = Convert.ToInt32(HttpContext.Request.Form["g"].ToString());
            int H = Convert.ToInt32(HttpContext.Request.Form["h"].ToString());
            int I = Convert.ToInt32(HttpContext.Request.Form["i"].ToString());
            int J = Convert.ToInt32(HttpContext.Request.Form["j"].ToString());
            int K = Convert.ToInt32(HttpContext.Request.Form["k"].ToString());
            int L = Convert.ToInt32(HttpContext.Request.Form["l"].ToString());
            int M = Convert.ToInt32(HttpContext.Request.Form["m"].ToString());
            int N = Convert.ToInt32(HttpContext.Request.Form["n"].ToString());
            int O = Convert.ToInt32(HttpContext.Request.Form["o"].ToString());

            var game = HttpContext.Request.Form["name"].ToString();
            int sum = A+B+C+D+E+F+G+H+I+J+K+L+M+N+O;
            int P = (A*620)+(B*550)+(C*360)+(D*130)+(E*480)+(F*510)+(G*610)+(H*220)+(I*145)+(J*310)+(K*210)+(L*510)+(M*650)+(N*430)+(O*220);
            ViewBag.qty = sum.ToString();
            ViewBag.namegame = game;
            ViewBag.total = P.ToString();
            return View("order");
        }
        public IActionResult Getname()
        {
            var fullname = HttpContext.Request.Form["name"].ToString();
            ViewBag.name = fullname;
            return View("Index");
        }
    }
}
