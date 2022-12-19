﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArchentsFirstProject.Models;
namespace ArchentsFirstProject.Controllers
{
    public class AccessoriesController : Controller
    {
        // GET: Accessories
        private ArchentsEntities6 db=new ArchentsEntities6();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Accessories()
        {
            var result = db.Products1.Where(x=>x.CategoryID==1801).ToList();
            ViewBag.Data = result;
            return View();
        }
    }
}