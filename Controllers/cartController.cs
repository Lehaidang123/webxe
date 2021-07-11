using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DCXEMAY.Controllers
{
    public class cartController : Controller
    {
        // GET: cart
        public ActionResult Cart()
        {
            return View();
        }
    }
}