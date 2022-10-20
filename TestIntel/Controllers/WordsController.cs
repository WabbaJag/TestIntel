using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestIntel.Models;

namespace TestIntel.Controllers
{
    public class WordsController : Controller
    {
        // GET: Words
        public ActionResult Index()
        {
            return View(new Words());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Words wor)
        {
            if (ModelState.IsValid)
            {
                if(wor.Word != null)
                {
                    var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

                    string sentence = wor.Word.ToLower();

                    wor.Amount = sentence.Count(c => vowels.Contains(c));
                }

            }

            return View(wor);
        }
    }
}