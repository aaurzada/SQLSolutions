﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SQLSolutions.Areas.Admin.Controllers
{
    public class BooksController : Controller
    {
        // GET: Admin/Books
        public ActionResult Index()
        {
            //return View();
            return Content("Books");
        }
    }
}