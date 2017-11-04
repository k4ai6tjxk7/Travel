using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelWeb.Controllers
{
    public class AuthorController : Controller
    {
        //關於作者
        // GET: Author
        public ActionResult Index()
        {
            return View();
        }
    }
}