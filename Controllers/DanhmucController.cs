using DCXEMAY.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DCXEMAY.Controllers
{
    public class DanhmucController : Controller
    {
        private Model2 db = new Model2();
        // GET: Danhmuc
        public ActionResult Nhot()
        {
            SanPham sp = new SanPham();

            var sanPhams = db.SanPhams.Include(s => s.DanhMuc);
            string t = sp.IDDanhmuc;

            return View(db.SanPhams.ToList());
        }


        public ActionResult Phuocxe()
        {
            SanPham sp = new SanPham();

            var sanPhams = db.SanPhams.Include(s => s.DanhMuc);
            string t = sp.IDDanhmuc;

            return View(db.SanPhams.ToList());
        }
        public ActionResult mamxe()
        {
            SanPham sp = new SanPham();

            var sanPhams = db.SanPhams.Include(s => s.DanhMuc);
            string t = sp.IDDanhmuc;

            return View(db.SanPhams.ToList());
        }

        public ActionResult octitan()
        {
            SanPham sp = new SanPham();

            var sanPhams = db.SanPhams.Include(s => s.DanhMuc);
            string t = sp.IDDanhmuc;

            return View(db.SanPhams.ToList());
        }

        public ActionResult dochoixe()
        {
            SanPham sp = new SanPham();

            var sanPhams = db.SanPhams.Include(s => s.DanhMuc);
            string t = sp.IDDanhmuc;

            return View(db.SanPhams.ToList());
        }

        public ActionResult voxe()
        {
            SanPham sp = new SanPham();

            var sanPhams = db.SanPhams.Include(s => s.DanhMuc);
            string t = sp.IDDanhmuc;

            return View(db.SanPhams.ToList());
        }

    }
}