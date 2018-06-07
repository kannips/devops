using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class usermodel
    {
        public List<SelectListItem> ListItems { get; set; }
        public int SelectedItem { get; set; }
        public List<SelectListItem> ListItems1 { get; set; }
    }
}