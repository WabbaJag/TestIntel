using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestIntel.Models;

namespace TestIntel.Controllers
{
    public class PersonsController : Controller
    {
        // GET: Persons
        public ActionResult Index()
        {
            Person p = new Person();
            return View(p.FilteredList());
        }
    }
}