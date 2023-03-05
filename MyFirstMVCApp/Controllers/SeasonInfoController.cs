using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstMVCApp.Models;

namespace MyFirstMVCApp.Controllers
{
    public class SeasonInfoController : Controller
    {
        // GET: SeasonInfo
        public ActionResult Index()
        {
            ViewBag.Title = "Wisest Home";
            return View();
        }

        public ActionResult Season(int? temperature)
        {
            ViewBag.Temp = temperature;
            if (temperature == null)
            {
                ViewBag.Temp = "unknown";
            }

            if (temperature == null) ViewBag.Season = "unkbown";
            else
            {
                TemperatureIfController temperatureIfController = new TemperatureIfController();
                ViewBag.Season = temperatureIfController.WhatSeason((int)temperature);
                //TemperatureIfController temperatureIfController = new TemperatureIfController();
                //ViewBag.Season = temperatureIfController.WhatSeason((int)temperature);
            }
            return View();
        }
    }
}