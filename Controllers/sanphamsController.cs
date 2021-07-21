using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DCXEMAY.Models;
using Microsoft.AspNet.Identity;

namespace DCXEMAY.Controllers
{
    public class SanPhamsController : Controller
    {
        private Model1 db = new Model1();

        // GET: SanPhams
        public ActionResult Index(string searchString)
        {
            var sp = from l in db.SanPhams // lấy toàn bộ liên kết
                     select l;

            if (!String.IsNullOrEmpty(searchString)) // kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
                //  sp = SanPham.Where(s => s.Contains(searchString)); //lọc theo chuỗi tìm
                sp = db.SanPhams.Where(s => s.TenSP.Contains(searchString));
            }
            var sanPhams = db.SanPhams.Include(s => s.DanhMuc);
            return View(sp);
        }

        // GET: SanPhams/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }

        // GET: SanPhams/Create
        public ActionResult Create()
        {
            ViewBag.IDDanhmuc = new SelectList(db.DanhMucs, "IDDanhmuc", "TenDanhmuc");
            return View();
        }

        // POST: SanPhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Include = "IDSanpham,TenSP,SoLuong,GiaSP,MoTa,URLImage,IDDanhmuc")] SanPham sanPham, HttpPostedFileBase file)
        {
            try
            {



                if (file != null)
                {
                    string filename = Path.GetFileName(file.FileName);
                    string extension = Path.GetExtension(file.FileName);
                    filename = filename + extension;
                    sanPham.URLImage = "~/Content/Images/" + filename;
                    file.SaveAs(Path.Combine(HttpContext.Server.MapPath("~/Content/Images/"), filename));


                }

                sanPham.DanhMucs = db.DanhMucs.ToList();
               
                db.SanPhams.Add(sanPham);
                db.SaveChanges();
                return RedirectToAction("Index");



            }
            catch
            {

                return View(sanPham);
            }
            //    ViewBag.IDDanhmuc = new SelectList(db.DanhMucs, "IDDanhmuc", "TenDanhmuc", sanPham.IDDanhmuc);
        }



        // GET: SanPhams/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDDanhmuc = new SelectList(db.DanhMucs, "IDDanhmuc", "TenDanhmuc", sanPham.IDDanhmuc);
            return View(sanPham);
        }

        // POST: SanPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDSanpham,TenSP,SoLuong,GiaSP,MoTa,URLImage,IDDanhmuc")] SanPham sanPham, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string filename = Path.GetFileName(file.FileName);
                    string extension = Path.GetExtension(file.FileName);
                    filename = filename + extension;
                    sanPham.URLImage = "~/Content/Images/" + filename;
                    file.SaveAs(Path.Combine(HttpContext.Server.MapPath("~/Content/Images/"), filename));
                }
                db.Entry(sanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDDanhmuc = new SelectList(db.DanhMucs, "IDDanhmuc", "TenDanhmuc", sanPham.IDDanhmuc);
            return View(sanPham);
        }

        // GET: SanPhams/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }

            return View(sanPham);
        }

        // POST: SanPhams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SanPham sanPham = db.SanPhams.Find(id);
            db.SanPhams.Remove(sanPham);
          
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
