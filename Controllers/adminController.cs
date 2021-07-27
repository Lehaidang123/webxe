using DCXEMAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Net;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI;

namespace DCXEMAY.Controllers
{
    public class adminController : Controller
    {
        private Model1 db = new Model1();
        // GET: admin
        [Authorize(Users ="lehaidangxh@gmail.com")]
        public ActionResult admin()
        {
            return View();
        }


        // GET: SanPhams
        [Authorize(Users = "lehaidangxh@gmail.com")]
        public ActionResult Sanpham()
        {
            SanPham sanPham = new SanPham();
            return View(db.SanPhams.ToList());
        }
        [Authorize(Users = "lehaidangxh@gmail.com")]
        public ActionResult oderdetail()
        {
          
            return View(db.Oderdetails.ToList());
        }

        public ActionResult ExportToExcel()
        {
            var gv = new GridView();
            var g =new GridView();
            g.DataSource = db.Oderdetails.ToList();
            gv.DataSource = db.Oders.ToList();  
          
            gv.DataBind();
            g.DataBind();
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=DemoExcel.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "utf-8";
            StringWriter objStringWriter = new StringWriter();
            HtmlTextWriter objHtmlTextWriter = new HtmlTextWriter(objStringWriter);
            gv.RenderControl(objHtmlTextWriter);
            g.RenderControl(objHtmlTextWriter);

            Response.Output.Write(objStringWriter.ToString());
            Response.Flush();
            Response.End();
            return View("admin");
        }
    }
}