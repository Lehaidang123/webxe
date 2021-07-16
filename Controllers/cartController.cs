using DCXEMAY.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;


namespace DCXEMAY.Controllers
{
    public class cartController : Controller
    {

         Model1 db = new Model1();

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




        public ActionResult AddtoCard(int id)
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
            int  id = int.Parse( form["IDSanpham"]);
            int quantity = int.Parse(form["quantity"]);
            cart.updateQuantity(id, quantity);
               return RedirectToAction("ShowCart","cart");


        }
        public ActionResult RemoveCart(int id)
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
        public ActionResult Checkout(FormCollection form)
        {
            try
            {
                Cart cart = Session["Cart"] as Cart;



                Oder oder = new Oder();
             
          
                oder.NGay = DateTime.Now;
                oder.Diachi = form["diachi"];
                db.Oders.Add(oder);



              foreach (var item in cart.Items)
                {

                    Oderdetail oderdetail = new Oderdetail();
                 
                    oderdetail.Idoder = oder.Idoder;
                    oderdetail.IDSanpham = item._shopping_sp.IDSanpham;
                    oderdetail.gia = Convert.ToString(item._shopping_sp.GiaSP);
                    oderdetail.soluong = item._shopping_quantity;
                //   oderdetail.ID = int.Parse(User.Identity.GetUserId());
                    db.Oderdetails.Add(oderdetail);

                }
              
                db.SaveChanges();
                cart.ClearCart();
                return RedirectToAction("Trangchu", "Home");

            }
            catch
            {
                return View();
            }
         
        }

        public ActionResult giohang()
        {
            return View();
        }
        

        
    }
}