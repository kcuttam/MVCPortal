using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStoreSln.DataProvider;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ICategoryRepository productRepo = new CategoryRepository();
            return View(productRepo.GetAllCategories());
        }

    }
}
