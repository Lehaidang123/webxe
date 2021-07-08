using DCXEMAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.IO;

using Microsoft.AspNet.Identity;

namespace DCXEMAY.Controllers
{
    public class HomeController : Controller
    {
        private Model2 db = new Model2();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Trangchu()
        {
            var sampham = new SanPham();
           
            return View(db.SanPhams.ToList());
          //  ViewBag.IDDanhmuc = new SelectList(db.DanhMucs, "IDDanhmuc", "TenDanhmuc", sanPham.IDDanhmuc);
        }


    }
}