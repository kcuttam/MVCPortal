using System.Collections.Generic;
using WebStoreSln.Models;

namespace WebUI.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PageInfo PagingInfo { get; set; }
        public string CategoryName { get; set; }
    }
}