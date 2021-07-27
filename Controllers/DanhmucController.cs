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
        private Model1 db = new Model1();
        // GET: Danhmuc
        public ActionResult Nhot(string searchString)
        {
            var sp = from l in db.SanPhams // lấy toàn bộ liên kết
                     select l;

            if (!String.IsNullOrEmpty(searchString)) // kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
                //  sp = SanPham.Where(s => s.Contains(searchString)); //lọc theo chuỗi tìm
                sp = db.SanPhams.Where(s => s.TenSP.Contains(searchString));
            }

            return View(sp);
        }


        public ActionResult Phuocxe(string searchString)
        {
            var sp = from l in db.SanPhams // lấy toàn bộ liên kết
                     select l;

            if (!String.IsNullOrEmpty(searchString)) // kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
                //  sp = SanPham.Where(s => s.Contains(searchString)); //lọc theo chuỗi tìm
                sp = db.SanPhams.Where(s => s.TenSP.Contains(searchString));
            }

            return View(sp);
        }
        public ActionResult mamxe(string searchString)
        {
            var sp = from l in db.SanPhams // lấy toàn bộ liên kết
                     select l;

            if (!String.IsNullOrEmpty(searchString)) // kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
                //  sp = SanPham.Where(s => s.Contains(searchString)); //lọc theo chuỗi tìm
                sp = db.SanPhams.Where(s => s.TenSP.Contains(searchString));
            }

            return View(sp);
        }

        public ActionResult octitan(string searchString)
        {
            var sp = from l in db.SanPhams // lấy toàn bộ liên kết
                     select l;

            if (!String.IsNullOrEmpty(searchString)) // kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
                //  sp = SanPham.Where(s => s.Contains(searchString)); //lọc theo chuỗi tìm
                sp = db.SanPhams.Where(s => s.TenSP.Contains(searchString));
            }

            return View(sp);
        }

        public ActionResult dochoixe(string searchString)
        {
            var sp = from l in db.SanPhams // lấy toàn bộ liên kết
                     select l;

            if (!String.IsNullOrEmpty(searchString)) // kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
                //  sp = SanPham.Where(s => s.Contains(searchString)); //lọc theo chuỗi tìm
                sp = db.SanPhams.Where(s => s.TenSP.Contains(searchString));
            }

            return View(sp);
        }

        public ActionResult voxe(string searchString)
        {
            var sp = from l in db.SanPhams // lấy toàn bộ liên kết
                     select l;

            if (!String.IsNullOrEmpty(searchString)) // kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
                //  sp = SanPham.Where(s => s.Contains(searchString)); //lọc theo chuỗi tìm
                sp = db.SanPhams.Where(s => s.TenSP.Contains(searchString));
            }

            return View(sp);
        }
        public ActionResult dochoi(string searchString)
        {
            var sp = from l in db.SanPhams // lấy toàn bộ liên kết
                     select l;

            if (!String.IsNullOrEmpty(searchString)) // kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
                //  sp = SanPham.Where(s => s.Contains(searchString)); //lọc theo chuỗi tìm
                sp = db.SanPhams.Where(s => s.TenSP.Contains(searchString));
            }

            return View(sp);
        }

    }
}