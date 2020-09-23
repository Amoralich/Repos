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
        public string Index()
        {
            return "This is my default action...";
        }
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        public string Lol(string name, int numTimes, int id)
        {
            return HtmlEncoder.Default.Encode($"ID : {id}:)  :D {name}, numTime is: {numTimes}");
            
        }
    }
}