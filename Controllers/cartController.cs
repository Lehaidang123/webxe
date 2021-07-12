using DCXEMAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DCXEMAY.Controllers
{
    public class cartController : Controller
    {

         Model2 db = new Model2();
        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if (cart == null || Session["Cart"] == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
                
        }




        public ActionResult AddtoCard(string id)
        {
            var sp = db.SanPhams.Single(s => s.IDSanpham == id);
            if(sp !=null)
            {
                GetCart().Add(sp);
            }
            return RedirectToAction("ShowCart","cart");
        }
        // GET: cart

        public ActionResult ShowCart()
        {

            Cart cart = Session["Cart"] as Cart;
            if (cart == null)


                    return RedirectToAction("ShowCart","cart");

                Cart c = Session["Cart"] as Cart;

                return View(c);
            
        }

        public ActionResult giohang()
        {
            return View();
        }
    }
}