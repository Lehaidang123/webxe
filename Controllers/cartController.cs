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


        public ActionResult updateQuantity(FormCollection form)
        {
            Cart cart = Session["Cart"] as Cart;
            string id = form["IDSanpham"];
            int quantity = int.Parse(form["quantity"]);
            cart.updateQuantity(id, quantity);
               return RedirectToAction("ShowCart","cart");


        }
        public ActionResult RemoveCart(string id)
        {
            Cart cart = Session["Cart"] as Cart;
            cart.Remove(id);
            return RedirectToAction("ShowCart", "cart");
        }


        public PartialViewResult BagCart()
        {
            int tatol_item = 0;
            Cart cart = Session["Cart"] as Cart;
            if(cart!= null)
           
                tatol_item = cart.Total_quantity_Cart();
                ViewBag.QuantityCart = tatol_item;
                return PartialView("BagCart");
               
        }

        public ActionResult giohang()
        {
            return View();
        }
        

        
    }
}