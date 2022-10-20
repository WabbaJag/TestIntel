using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestIntel.Models;

namespace TestIntel.Controllers
{
    public class NumbersController : Controller
    {
        // GET: Numbers
        public ActionResult Index()
        {
            return View(new Numbers());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Numbers num)
        {
            if (ModelState.IsValid)
            {
                int a;
                a = num.Number;
                if (a % 3 == 0 && a % 5 == 0)
                {
                    num.Type = "foo bar";
                }
                else if (a % 5 == 0)
                {
                    num.Type = "foo";
                }
                else if (a % 3 == 0)
                {
                    num.Type = "bar";
                }
                else
                {
                    num.Type = "Not divisible by 3 or 5";
                }

            }

            return View(num);
        }
    }
}