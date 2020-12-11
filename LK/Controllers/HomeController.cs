using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LK.Models;

namespace LK.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            Datchik[] arrayDatchik =
            {
                new Datchik
                {
                    DatId = 5,
                    DatTipe = 1,
                    DatName = "Температура",
                    DatZnach = 31.22,
                    DatOnOff = true,
                    DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25),
                    DatEdIzm = " °C",
                    DatMinZnach = 0,
                    DatMaxZnach = 50

                },
                new Datchik
                {
                    DatId = 5,
                    DatTipe = 1,
                    DatName = "Температура 1",
                    DatZnach = 6.34,
                    DatOnOff = true,
                    DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25),
                    DatEdIzm = " °C",
                    DatMinZnach = 0,
                    DatMaxZnach = 50

                },
                new Datchik
                {
                    DatId = 5,
                    DatTipe = 1,
                    DatName = "Температура 2",
                    DatZnach = 61,
                    DatOnOff = true,
                    DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25),
                    DatEdIzm = " °C",
                    DatMinZnach = 0,
                    DatMaxZnach = 50

                },
                new Datchik
                {
                    DatId = 5,
                    DatTipe = 1,
                    DatName = "Влажность",
                    DatZnach = 95,
                    DatOnOff = true,
                    DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25),
                    DatEdIzm = " г/м³",
                    DatMinZnach = 20,
                    DatMaxZnach = 90
                },
                new Datchik
                {
                    DatId = 5,
                    DatTipe = 1,
                    DatName = "Объем",
                    DatZnach = 1200,
                    DatOnOff = false,
                    DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25),
                    DatEdIzm = " м³",
                    DatMinZnach = 200,
                    DatMaxZnach = 3000
                },
                new Datchik
                {
                    DatId = 5,
                    DatTipe = 1,
                    DatName = "Объем 2",
                    DatZnach = 2800,
                    DatOnOff = false,
                    DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25),
                    DatEdIzm = " м³",
                    DatMinZnach = 200,
                    DatMaxZnach = 3000
                },
                new Datchik
                {
                    DatId = 5,
                    DatTipe = 1,
                    DatName = "Объем 3",
                    DatZnach = 3000,
                    DatOnOff = false,
                    DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25),
                    DatEdIzm = " м³",
                    DatMinZnach = 200,
                    DatMaxZnach = 3000
                },
                new Datchik
                {
                    DatId = 5,
                    DatTipe = 1,
                    DatName = "Давление 1",
                    DatZnach = 4,
                    DatOnOff = true,
                    DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25),
                    DatEdIzm = " МПа",
                    DatMinZnach = 5,
                    DatMaxZnach = 8
                },
                new Datchik
                {
                    DatId = 5,
                    DatTipe = 1,
                    DatName = "Давление 2",
                    DatZnach = 6,
                    DatOnOff = true,
                    DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25),
                    DatEdIzm = " МПа",
                    DatMinZnach = 5,
                    DatMaxZnach = 8
                },
                new Datchik
                {
                    DatId = 5,
                    DatTipe = 1,
                    DatName = "Давление 3",
                    DatZnach = 2,
                    DatOnOff = true,
                    DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25),
                    DatEdIzm = " МПа",
                    DatMinZnach = 5,
                    DatMaxZnach = 8
                },
                new Datchik
                {
                    DatId = 5,
                    DatTipe = 1,
                    DatName = "Давление 4",
                    DatZnach = 5.42,
                    DatOnOff = true,
                    DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25),
                    DatEdIzm = " МПа",
                    DatMinZnach = 5,
                    DatMaxZnach = 8
                }
            };


           return View(arrayDatchik);

        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Docs()
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
