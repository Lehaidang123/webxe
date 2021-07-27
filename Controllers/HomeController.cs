using DCXEMAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.IO;
using PagedList.Mvc;


using Microsoft.AspNet.Identity;
using System.Configuration;

namespace DCXEMAY.Controllers
{
    public class HomeController : Controller
    {
        private Model1 db = new Model1();
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

       
        public ActionResult Trangchu(string searchString,int page=1,int size=10)
        {
            SanPham e = new SanPham();
            var sp = from l in db.SanPhams // lấy toàn bộ liên kết
                     select l;

            if (!String.IsNullOrEmpty(searchString)) // kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
               
                //  sp = SanPham.Where(s => s.Contains(searchString)); //lọc theo chuỗi tìm
                   sp = db.SanPhams.Where(s => s.TenSP.Contains(searchString));
               
            }
          
            var t = e.ListAllpage(page, size);

            return View(t);
         




            //  ViewBag.IDDanhmuc = new SelectList(db.DanhMucs, "IDDanhmuc", "TenDanhmuc", sanPham.IDDanhmuc);
        }
        public ActionResult test(FormCollection form)
        {
            var toEmail = ConfigurationManager.AppSettings["ToEmailAddress"].ToString();
                          new HelpMail().SendMail(form["mail"], "hrrr", "");
                          new HelpMail().SendMail(toEmail, "hrrr", "");

            return View();
        }


    }
}