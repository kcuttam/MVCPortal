using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStoreSln.DataProvider;
using WebStoreSln.Models;

namespace WebUI.Controllers
{
    public class CategoriesController : Controller
    {
        //
        // GET: /Categories/

        public string CatMenu()
        {
            return "Menu Category list";
        }

        public PartialViewResult CategoriesMenu()
        {
            ICategoryRepository productRepo = new CategoryRepository();
            IEnumerable<Category> categories = productRepo.GetAllCategories();
            return PartialView(categories);
        }

    }
}
