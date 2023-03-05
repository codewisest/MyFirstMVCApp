using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApp.Models
{
    public class TemperatureIfController : Controller
    {
        /// <summary>
        /// Returns the season based on the input temperature
        /// </summary>
        /// <param name="temp">in put temperature</param>
        /// <returns>string value of the season</returns>
        // [HttpGet]
        // [Route("api/temperatureif/whattemperature/{temp}")]
        public string WhatSeason(int temp)
        {
            if (temp > 20) return "Summer!";
            else if (temp > 15 && temp <= 20) return "Fall!";
            else if (temp > 10 && temp <= 15) return "Spring";
            else return "Winter";
        }

    }
}