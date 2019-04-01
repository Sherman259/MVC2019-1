﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class OsobaController : Controller
    {
        // GET: Osoba/PopuniOsobu
        public ActionResult PopuniOsobu()
        {
            return View();
        }

        // POST: Osoba/PopuniOsobu
        [HttpPost]
        public ActionResult PopuniOsobu(Osoba osoba)
        {
            return View(osoba);
        }
    }
}