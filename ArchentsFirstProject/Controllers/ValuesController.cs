﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArchentsFirstProject.Models;

namespace ArchentsFirstProject.Controllers
{
    public class ValuesController : Controller
    {
        // GET: Values
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public  ActionResult values()
        {

            return View();
        }
        [HttpPost]
        public ActionResult values(Products1 pro)
        {

            return View();
        }
      
    }
}
