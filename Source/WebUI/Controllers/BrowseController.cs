using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebStoreSln.DataProvider;
using WebStoreSln.Models;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class BrowseController : Controller
    {
        private IProductRepository productRepo;
        private ICategoryRepository categoryRepo;
        //
        // GET: /Browse/
        public BrowseController(ICategoryRepository categoryReposotory, IProductRepository productReposotory)
        {
            productRepo = productReposotory;
            categoryRepo = categoryReposotory;
        }
        public ActionResult Index()
        {
            //IProductRepository productRepo = new ProductRepository();
            return View(productRepo.GetProductsByCategory(1));
        }
        public ActionResult Products(int id, int page = 1)
        {
            int PageSize = 3;
            //ICategoryRepository categoryRepo = new CategoryRepository();
            //IProductRepository productRepo = new ProductRepository();
            IList<Product> products = productRepo.GetProductsByCategory(id);
            ProductListViewModel productList = new ProductListViewModel();
            productList.Products = products.OrderBy(p => p.Id).Skip((page - 1) * PageSize).Take(PageSize); ;
            productList.CategoryName = categoryRepo.GetAllCategories().First(cat => cat.Id == id).Name;

            PageInfo pagingInfo = new PageInfo();
            pagingInfo.TotalProducts = products.Count;
            pagingInfo.PageSize = PageSize;
            pagingInfo.CurrentPage = page;

            productList.PagingInfo = pagingInfo;
            return View(productList);
        }

        public ActionResult ProductDetail(long id)
        {
            //IProductRepository productRepo = new ProductRepository();
            return View(productRepo.GetAllProducts().Where(p => p.Id == id).FirstOrDefault());
        }
    }
}
