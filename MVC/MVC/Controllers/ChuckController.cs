using MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ChuckController : Controller
    {
        // GET: Chuck
        public ActionResult Index()
        {
            RandChuckJoke joke;

            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync("https://api.chucknorris.io/jokes/random").Result;

                joke = JsonConvert.DeserializeObject<RandChuckJoke>(json);
            }
            
            return View(joke);
        }
    }
}