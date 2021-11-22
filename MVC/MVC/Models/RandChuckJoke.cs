using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class RandChuckJoke
    {
        public string icon_url {get;set;}
        public string id {get;set;}
        public string url {get;set;}
        public string value { get; set; }

        public RandChuckJoke()
        {
            icon_url = string.Empty;
            id = string.Empty;
            url = string.Empty;
            value = string.Empty;
        }
    }
}