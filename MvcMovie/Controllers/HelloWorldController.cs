using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            if(DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                ViewBag.greeting = "Good tuesday.";
            }
            else
            {
                ViewBag.greeting = "Good tuesday.";
            }
            return View();
        }

        public IActionResult Welcome(string name,int numTimes=1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["Numtimes"] = numTimes;
            return View();
        }

        public string Lol(string name, int numTimes, int id)
        {
            return HtmlEncoder.Default.Encode($"ID : {id}:)  :D {name}, numTime is: {numTimes}");

        }
    }
}