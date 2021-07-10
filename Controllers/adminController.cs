﻿using DCXEMAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace DCXEMAY.Controllers
{
    public class adminController : Controller
    {
        private Model2 db = new Model2();
        // GET: admin
        [Authorize]
        public ActionResult admin()
        {
            return View();
        }
      

        // GET: SanPhams
        public ActionResult Sanpham()
        {
            SanPham sanPham = new SanPham();
            return View(db.SanPhams.ToList());
        }
    }
}