using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XSSDemo.ViewModels;
using Ganss.Xss; // Importing the Ganss.XSS library

namespace XSSDemo.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HtmlSanitizer _sanitizer;// Creating a static instance of the sanitizer
        static HomeController()
        {
            _sanitizer = new HtmlSanitizer(); // Instantiating the sanitizer
            _sanitizer.AllowedTags.Add("p");
            _sanitizer.AllowedTags.Add("strong");
            _sanitizer.AllowedTags.Add("em");
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
       
        public ActionResult Index(FeedbackVM model)
        {   // Sanitize the user input to remove any malicious script
            string sanitizedComment = _sanitizer.Sanitize(model.Comment);
            ViewBag.Comment = sanitizedComment;
           
            return View();
        }
    }
}