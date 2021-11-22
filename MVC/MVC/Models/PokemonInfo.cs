using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Sprites
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
    }
    public class PokemonInfo
    {
        public string name { get; set; }
        public string weight { get; set; }
        public string height { get; set; }
        public Sprites sprites { get; set; }
    }
}