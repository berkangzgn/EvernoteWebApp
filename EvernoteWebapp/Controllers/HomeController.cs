using Evernote.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvernoteWebapp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Evernote.BusinessLayer.ForTest test = new Evernote.BusinessLayer.ForTest();
            //test.InsertTest();
            //test.UpdateTest();
            test.DeleteTest();
            return View();
        }
    }
}